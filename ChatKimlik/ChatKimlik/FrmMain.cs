using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatKimlik
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Trim() != "")
            {
                File.WriteAllText("kim.dat", txtID.Text + "|" + txtAdSoyad.Text.Trim(), Encoding.Default);
                MessageBox.Show("Kaydedildi", "Dursun Katar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bi isim yaz bari", "Dursun Katar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int length = 10;
            var str_build = new StringBuilder();
            var random = new Random();
            char letter;
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            txtID.Text = str_build.ToString();
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
