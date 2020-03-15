namespace ChatClientCoklu
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrGizle = new System.Windows.Forms.Timer(this.components);
            this.lblGizle = new System.Windows.Forms.Label();
            this.lblHakkinda = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(8, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(156, 327);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 339);
            this.panel1.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Black;
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(-1, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(194, 21);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Mini Chat";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBaslik_MouseDown);
            this.lblBaslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBaslik_MouseMove);
            this.lblBaslik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBaslik_MouseUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-1, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 354);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(188, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 354);
            this.label2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 8);
            this.label4.TabIndex = 8;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tmrGizle
            // 
            this.tmrGizle.Enabled = true;
            this.tmrGizle.Interval = 250;
            this.tmrGizle.Tick += new System.EventHandler(this.tmrGizle_Tick);
            // 
            // lblGizle
            // 
            this.lblGizle.AutoSize = true;
            this.lblGizle.BackColor = System.Drawing.Color.Black;
            this.lblGizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGizle.ForeColor = System.Drawing.Color.White;
            this.lblGizle.Location = new System.Drawing.Point(173, 2);
            this.lblGizle.Name = "lblGizle";
            this.lblGizle.Size = new System.Drawing.Size(15, 15);
            this.lblGizle.TabIndex = 9;
            this.lblGizle.Text = "X";
            this.lblGizle.Click += new System.EventHandler(this.lblGizle_Click);
            // 
            // lblHakkinda
            // 
            this.lblHakkinda.AutoSize = true;
            this.lblHakkinda.BackColor = System.Drawing.Color.Black;
            this.lblHakkinda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHakkinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHakkinda.ForeColor = System.Drawing.Color.White;
            this.lblHakkinda.Location = new System.Drawing.Point(159, 2);
            this.lblHakkinda.Name = "lblHakkinda";
            this.lblHakkinda.Size = new System.Drawing.Size(14, 15);
            this.lblHakkinda.TabIndex = 10;
            this.lblHakkinda.Text = "?";
            this.lblHakkinda.Click += new System.EventHandler(this.lblHakkinda_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(190, 372);
            this.Controls.Add(this.lblHakkinda);
            this.Controls.Add(this.lblGizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSS Çet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer tmrGizle;
        private System.Windows.Forms.Label lblGizle;
        private System.Windows.Forms.Label lblHakkinda;
    }
}

