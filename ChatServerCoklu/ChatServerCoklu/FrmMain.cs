using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ChatServerCoklu
{
    public partial class FrmMain : Form
    {
        ChatEngine engine = new ChatEngine();
        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            engine.onlineKisileriYenile();
        }

        private void TmrGizle_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tmrGizle.Enabled = false;
        }
    }
}
