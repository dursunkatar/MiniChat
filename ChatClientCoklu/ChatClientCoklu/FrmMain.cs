using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatClientCoklu
{
    public partial class FrmMain : Form
    {
        private readonly static Mutex mutex = new Mutex(true, "MiniChat-DursunKatar");
        private TcpClient client;
        private NetworkStream networkStream;
        private StreamWriter streamWriter;
        private StreamReader streamReader;
        private readonly List<FrmChat> chatForms = new List<FrmChat>();
        private static volatile object obj = new object();
        private byte[] test = new byte[] { 0, 13, 10 };
        public string Kimlik { get; set; }
        private string ip;
        private int port;
        private Point ilkkonum;
        private bool durum = false;
        private bool gizlimi = true;
        private bool hicBaglandimi = false;

        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            client = new TcpClient();
        }

        private void connect()
        {
            try
            {
                client.Connect(ip, port);
                networkStream = new NetworkStream(client.Client);
                streamWriter = new StreamWriter(networkStream);
                streamReader = new StreamReader(networkStream);
                hicBaglandimi = true;
                Thread.Sleep(500);
                streamWriter.WriteLine(Kimlik);
                streamWriter.Flush();
                onlineKisileriAl(streamReader.ReadLine());
                baglantiTest();
                mesajBekle();
                listView.Enabled = true;
            }
            catch (Exception ex)
            {
                lblBaslik.Text = "Mini Chat (Not Connect!)";
                Thread.Sleep(3000);
                if (hicBaglandimi)
                {
                    sifirla();
                    client = new TcpClient();
                    hicBaglandimi = false;
                }
                connect();
            }
        }
        private void Baglan()
        {
            var th = new Thread(() =>
            {
                connect();
            });
            th.IsBackground = false;
            th.Start();
        }


        private void mesajBekle()
        {
            var th = new Thread(() =>
            {
                try
                {
                    while (networkStream.CanRead)
                    {
                        if (client.Client.Available > 0)
                        {
                            var gelen = streamReader.ReadLine().Trim();
                            if (gelen != "\0")
                            {
                                if (gelen.StartsWith("[kisiler]"))
                                {
                                    onlineKisileriAl(gelen);
                                    lblBaslik.Text = "Mini Chat (" + listView.Items.Count + ")";
                                }
                                else
                                {
                                    var (kisi, mesaj) = mesajiAyikla(gelen);

                                    var m = new Thread(() =>
                                    {
                                        var chatForm = getChatForm(kisi);
                                        this.Invoke((MethodInvoker)delegate ()
                                        {
                                            if (!chatForm.Visible)
                                                chatForm.Show();

                                            if (chatForm.WindowState == FormWindowState.Minimized)
                                            {
                                                chatForm.WindowState = FormWindowState.Normal;
                                            }
                                            chatForm.GelenMesaj(mesaj);
                                        });
                                    });

                                    m.IsBackground = false;
                                    m.Start();
                                }

                            }
                        }
                    }
                }
                catch
                {

                }
            });
            th.IsBackground = false;
            th.Start();
        }

        private (Kisi, string) mesajiAyikla(string mesaj)
        {
            string[] s = mesaj.Split('|');
            var kisi = new Kisi { KaynakKisiID = s[2], KaynakKisiIsim = s[3], KisiId = s[0], KisiIsim = s[1] };
            return (kisi, s[4]);
        }


        private void onlineKisileriAl(string onlinekisiler)
        {
            var yeniGelenKisiler = new List<Kisi>();
            string[] kisiler = onlinekisiler.Replace("[kisiler]", "").Split(',');
            string kendimID = Kimlik.Split('|')[0];
            for (int i = 0; i < kisiler.Length - 1; i++)
            {
                var _k = kisiler[i].Split('|');
                if (_k[0] == kendimID || _k[1].Trim() == "")
                    continue;

                var kisi = new Kisi();
                kisi.KisiId = _k[0];
                kisi.KisiIsim = _k[1];
                yeniGelenKisiler.Add(kisi);
            }

            Kisi _kisi = null;
            foreach (ListViewItem item in listView.Items)
            {
                _kisi = (Kisi)item.Tag;
                int index = yeniGelenKisiler.FindIndex(m => m.KisiId == _kisi.KisiId);
                if (index == -1)
                {
                    item.Remove();
                    lock (obj)
                    {
                        chatForms.Remove(chatForms.FirstOrDefault(m => m.Kisi.KisiId == _kisi.KisiId));
                    }
                }
                else
                {
                    yeniGelenKisiler.RemoveAt(index);
                }
            }

            foreach (Kisi kisi in yeniGelenKisiler)
            {
                var lvi = new ListViewItem();
                lvi.Text = kisi.KisiIsim;
                lvi.Tag = kisi;
                listView.Items.Add(lvi);
            }

        }
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            var kisi = listView.SelectedItems[0].Tag as Kisi;
            var chatForm = getChatForm(kisi);
            chatForm.Show();
        }


        private FrmChat getChatForm(Kisi kisi)
        {
            FrmChat chatForm;
            lock (obj)
            {
                chatForm = chatForms.FirstOrDefault(m => m.Kisi.KisiId == kisi.KisiId);
            }

            if (chatForm == null)
            {
                chatForm = new FrmChat();
                kisi.KaynakKisiID = Kimlik.Split('|')[0];
                kisi.KaynakKisiIsim = Kimlik.Split('|')[1];
                chatForm.Kisi = kisi;
                chatForm.Writer = streamWriter;
                chatForms.Add(chatForm);
            }
            return chatForm;
        }


        private void yenile()
        {
            sifirla();
            client = new TcpClient();
            Baglan();

        }
        private void sifirla()
        {
            if (networkStream != null)
            {
                streamWriter.Dispose();
                streamReader.Dispose();
                networkStream.Dispose();
                client.Client.Close();
                client.Client.Dispose();
                client.Close();
                client = null;
                streamWriter = null;
                streamReader = null;
                networkStream = null;
            }
        }

        private void baglantiTest()
        {
            var th = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Thread.Sleep(5000);
                        client.Client.Send(test);
                    }
                }
                catch
                {
                    lblBaslik.Text = "Mini Chat (Not Connect!)";
                    listView.Enabled = false;
                    listView.Items.Clear();
                    chatForms.Clear();
                    yenile();
                }
            });
            th.IsBackground = false;
            th.Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.Exit();
            }
            else
            {
                init();
                Baglan();
            }
        }

        private void init()
        {
            if (!File.Exists("kim.dat") || !File.Exists("ip.dat"))
            {
                this.Close();
            }
            else
            {
                Kimlik = File.ReadAllText("kim.dat", Encoding.Default).Trim();
                string[] tmp = File.ReadAllText("ip.dat", Encoding.Default).Trim().Split(':');
                ip = tmp[0];
                port = int.Parse(tmp[1]);
            }
        }


        private void lblBaslik_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            this.Cursor = Cursors.SizeAll;
            ilkkonum = e.Location;
        }

        private void lblBaslik_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void lblBaslik_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            this.Cursor = Cursors.Default;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notify();
                gizlimi = true;
            }
        }
        private void notify()
        {
            notifyIcon.Visible = true;
            notifyIcon.Text = "Mini Chat";
            notifyIcon.Icon = this.Icon;
            gizlimi = true;
            Hide();
        }

        private void formuGoster()
        {
            notifyIcon.Visible = false;
            gizlimi = false;
            Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formuGoster();
        }

        private void tmrGizle_Tick(object sender, EventArgs e)
        {
            notify();
            tmrGizle.Enabled = false;
        }

        private void lblGizle_Click(object sender, EventArgs e)
        {
            notify();
        }

        private void lblHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dursun Katar" + Environment.NewLine + "github.com/dursunkatar", "Ben", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
