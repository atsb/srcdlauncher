namespace CNlaunch
{
    partial class frmabout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmabout));
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(9, 10);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(167, 100);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Black;
            this.lblTitle1.Location = new System.Drawing.Point(193, 14);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(250, 18);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "SRCD Doom launcher";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.Color.Black;
            this.lblTitle3.Location = new System.Drawing.Point(400, 32);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(43, 13);
            this.lblTitle3.TabIndex = 3;
            this.lblTitle3.Text = "v1.4.2";
            // 
            // lblTitle4
            // 
            this.lblTitle4.ForeColor = System.Drawing.Color.Black;
            this.lblTitle4.Location = new System.Drawing.Point(193, 51);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(252, 52);
            this.lblTitle4.TabIndex = 5;
            this.lblTitle4.Text = "Friendly launcher for Ultimate Doom, Doom 2, Final Doom, Heretic, Hexen and Strif" +
                "e by Ben Jones, Zvonimir Bužanić and Gibbon (SRCD Doom)";
            this.lblTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle4.Click += new System.EventHandler(this.lblTitle4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "https://github.com/atsb/srcdarchive.github.io";
            // 
            // frmabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmabout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About launcher";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmdOK_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdOK_Click);
            this.Click += new System.EventHandler(this.cmdOK_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label label1;
    }
}