namespace ChatClientCoklu
{
    partial class FrmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.txtGelen = new System.Windows.Forms.TextBox();
            this.txtGiden = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGelen
            // 
            this.txtGelen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelen.Location = new System.Drawing.Point(8, 25);
            this.txtGelen.Multiline = true;
            this.txtGelen.Name = "txtGelen";
            this.txtGelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGelen.Size = new System.Drawing.Size(454, 195);
            this.txtGelen.TabIndex = 0;
            // 
            // txtGiden
            // 
            this.txtGiden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiden.Location = new System.Drawing.Point(8, 227);
            this.txtGiden.Name = "txtGiden";
            this.txtGiden.Size = new System.Drawing.Size(454, 22);
            this.txtGiden.TabIndex = 1;
            this.txtGiden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiden_KeyDown);
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Black;
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(475, 19);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblBaslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.lblBaslik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 280);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(470, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(5, 280);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 10);
            this.label4.TabIndex = 6;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.Color.Black;
            this.lblKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKapat.ForeColor = System.Drawing.Color.White;
            this.lblKapat.Location = new System.Drawing.Point(454, 2);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(14, 13);
            this.lblKapat.TabIndex = 8;
            this.lblKapat.Text = "X";
            this.lblKapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Black;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(435, 1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(13, 13);
            this.lblMinimize.TabIndex = 9;
            this.lblMinimize.Text = "_";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(472, 254);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtGiden);
            this.Controls.Add(this.txtGelen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChat";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChat_FormClosing);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelen;
        private System.Windows.Forms.TextBox txtGiden;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label lblMinimize;
    }
}