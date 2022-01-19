namespace CNlaunch
{
    partial class frmPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPort));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.canCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cmdFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to cndoom.exe:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(46, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(278, 20);
            this.txtPort.TabIndex = 0;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(334, 44);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(30, 22);
            this.cmdOpen.TabIndex = 1;
            this.cmdOpen.Text = ". . .";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // canCancel
            // 
            this.canCancel.Location = new System.Drawing.Point(290, 146);
            this.canCancel.Name = "canCancel";
            this.canCancel.Size = new System.Drawing.Size(75, 23);
            this.canCancel.TabIndex = 3;
            this.canCancel.Text = "Cancel";
            this.canCancel.UseVisualStyleBackColor = true;
            this.canCancel.Click += new System.EventHandler(this.canCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Enabled = false;
            this.cmdOK.Location = new System.Drawing.Point(207, 146);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path to WAD files";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(46, 95);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(278, 20);
            this.txtData.TabIndex = 5;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            // 
            // cmdFolder
            // 
            this.cmdFolder.Location = new System.Drawing.Point(334, 94);
            this.cmdFolder.Name = "cmdFolder";
            this.cmdFolder.Size = new System.Drawing.Size(30, 22);
            this.cmdFolder.TabIndex = 6;
            this.cmdFolder.Text = ". . .";
            this.cmdFolder.UseVisualStyleBackColor = true;
            this.cmdFolder.Click += new System.EventHandler(this.cmdFolder_Click);
            // 
            // frmPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 187);
            this.Controls.Add(this.cmdFolder);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.canCancel);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button canCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button cmdFolder;
    }
}