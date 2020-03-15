namespace ChatServerCoklu
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
            this.tmrTest = new System.Windows.Forms.Timer(this.components);
            this.tmrGizle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrTest
            // 
            this.tmrTest.Enabled = true;
            this.tmrTest.Interval = 3000;
            this.tmrTest.Tick += new System.EventHandler(this.tmrTest_Tick);
            // 
            // tmrGizle
            // 
            this.tmrGizle.Enabled = true;
            this.tmrGizle.Interval = 250;
            this.tmrGizle.Tick += new System.EventHandler(this.TmrGizle_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(259, 170);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Chat Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTest;
        private System.Windows.Forms.Timer tmrGizle;
    }
}

