using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace CNlaunch
{
    public partial class frmPort : Form
    {
        public frmPort()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Tools.ButtonPress = 1;
            Tools.Port = txtPort.Text;
            Tools.DataFiles = txtData.Text;
            this.Close();
        }

        private void canCancel_Click(object sender, EventArgs e)
        {
            Tools.ButtonPress = 0;
            this.Close();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            cmdOK.Enabled = (txtPort.Text.Trim().Length > 0);
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Program";
            ofd.Filter = "Program Files(*.exe)|*.exe|All Files(*.*)|*.*";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPort.Text = ofd.FileName;
            }
        }

        private void frmPort_Load(object sender, EventArgs e)
        {
            txtPort.Text = Tools.Port;
            txtData.Text = Tools.DataFiles;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                if (cmdOK.Enabled)
                {
                    cmdOK_Click(sender, e);
                }
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPort_KeyPress(sender, e);
        }

        private void cmdFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Folder:";
            fbd.SelectedPath = txtData.Text;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Set text with selected path
                txtData.Text = Tools.FixPath(fbd.SelectedPath);
            }
        }
    }
}
