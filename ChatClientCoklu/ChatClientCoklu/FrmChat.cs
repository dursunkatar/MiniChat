using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatClientCoklu
{
    public partial class FrmChat : Form
    {
        public Kisi Kisi { get; set; }
        public StreamWriter Writer { get; set; }

        Point ilkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;
        public FrmChat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }



        public void GelenMesaj(string mesaj)
        {
            txtGelen.AppendText("O: " + mesaj + Environment.NewLine);

        }


        private void txtGiden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Writer.WriteLine(Kisi.KaynakKisiID + "|" + Kisi.KaynakKisiIsim + "|" + Kisi.KisiId + "|" + Kisi.KisiIsim + "|" + txtGiden.Text);
                    Writer.Flush();
                    txtGelen.AppendText("Ben: " + txtGiden.Text + Environment.NewLine);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    txtGiden.Text = "";
                    txtGelen.ScrollToCaret();
                }
                catch
                {
                    this.Hide();
                }
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            this.Cursor = Cursors.SizeAll;
            ilkkonum = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            this.Cursor = Cursors.Default;
        }


        private void FrmChat_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = Kisi.KisiIsim;
            this.Text = Kisi.KisiIsim;
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
