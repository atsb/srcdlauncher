using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using INIReader;

namespace CNlaunch
{
    public partial class frmmain : Form
    {
        private cINI ini = new cINI();
        private enum iDemo { Record, Play };
        private List<string> IWads = new List<string>();
        private string iWad = string.Empty;
        private string iSkill = string.Empty;
        private const string Quote = "\"";
        private iDemo Demo;

        private void SetHeretic1Maps()
        {
            //Add Heretic maps
            for (int x = 1; x <= 3; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    cboLevel.Items.Add(x + "" + y);
                }
            }
            //Add final map
            cboLevel.Items.Add("41");
        }

        private void SetHereticMaps()
        {
            //Add Heretic maps
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    cboLevel.Items.Add(x + "" + y);
                }
            }
            //Add final maps
            cboLevel.Items.Add("61");
            cboLevel.Items.Add("62");
            cboLevel.Items.Add("63");
        }

        private void SetDoom1Maps()
        {
            //Add Ultimate Doom maps
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    cboLevel.Items.Add(x + " " + y);
                }
            }
        }

        private void SetDoom2Maps(int StartIdx,int MaxMap)
        {
            //Add Doom2 maps
            for (int x = StartIdx; x <= MaxMap; x++)
            {
                cboLevel.Items.Add(string.Format(x.ToString("00")));
            }
        }

        private void SetDoomMaps(string wadfile)
        {
            //This fills the level combobox with the map names
            cboLevel.Items.Clear();
            cboLevel.Items.Add("");

            switch (wadfile.ToLower())
            {
                case "doom.wad":
                    SetDoom1Maps();
                    break;
                case "doom1.wad":
                    SetDoom1Maps();
                    break;
                case "doomu.wad":
                    SetDoom1Maps();
                    break;
                case "doom2.wad":
                    SetDoom2Maps(1,32);
                    break;
                case "tnt.wad":
                    SetDoom2Maps(1,32);
                    break;
                case "plutonia.wad":
                    SetDoom2Maps(1,32);
                    break;
                case "heretic.wad":
                    SetHereticMaps();
                    break;
                case "heretic1.wad":
                    SetHeretic1Maps();
                    return;
                case "hexen.wad":
                    SetDoom2Maps(1,41);
                    break;
                case "hexdd.wad":
                    SetDoom2Maps(33, 60);
                    break;
                case "strife1.wad":
                    SetDoom2Maps(1, 34);
                    break;
                case "freedm064.wad":
                    SetDoom2Maps(1, 32);
                    break;
                case "freedm.wad":
                    SetDoom2Maps(1, 32);
                    break;
            }
        }

        private int GetIWadIndex()
        {
            try
            {
                return Convert.ToInt32(ini.GetValue("main", "iwad", ""));
            }
            catch
            {
                return 0;
            }
        }

        private int GetLevelIndex()
        {
            try
            {
                return Convert.ToInt32(ini.GetValue("main", "level", ""));
            }
            catch
            {
                return 0;
            }
        }

        private int GetSkillIndex()
        {
            try
            {
                return Convert.ToInt32(ini.GetValue("main", "skill", ""));
            }
            catch
            {
                return 0;
            }
        }

        private string BuildPWadList(CheckedListBox cList)
        {
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < cList.CheckedItems.Count; x++)
            {
                sb.Append(Quote + Tools.DataFiles + cList.CheckedItems[x] + Quote + " ");
            }
            return sb.ToString().TrimEnd();
        }

        private void RunDoom()
        {
            Process p = new Process();
            string Arg          = string.Empty;
            string nSound       = string.Empty;
            string fast         = string.Empty;
            string nMusic       = string.Empty;
            string Level        = string.Empty;
            string nosfx        = string.Empty;
            string noMonsters   = string.Empty;
            string Speed        = string.Empty;
            string Max          = string.Empty;
            string Nmare        = string.Empty;
            string Nm100s       = string.Empty;
            string Tyson        = string.Empty;
            string Pacifist     = string.Empty;
            string Movie        = string.Empty;
            string Episode      = string.Empty;
            string Respawn      = string.Empty;
            string Turbo        = string.Empty;
            string ddemo        = string.Empty;
            string QSdelay      = string.Empty;
            string Stats        = string.Empty;
            string ConnectTo    = string.Empty;

            //Set filename
            p.StartInfo.FileName = Tools.Port;

            //Check for level map
            if (cboLevel.Text.Length > 0)
            {
                Level = " -warp " + cboLevel.Text;
            }

            //Check for fast monsters
            if (chkFast.Checked)
            {
                fast = " -fast";
            }

            //Check if using no sound
            if (!chkSound.Checked)
            {
                nSound = " -nosound";
            }
            //Check for sound effects
            if (!chkeffects.Checked)
            {
                nosfx = " -nosfx";
            }
            //Check for no music
            if (!chkmusic.Checked)
            {
                nMusic = " -nomusic";
            }

            //Check for no monsters
            if (chkNomonsters.Checked)
            {
                noMonsters = " -nomonsters";
            }
            //Check for Respawning monsters
            if (chkRespawn.Checked)
            {
                Respawn = " -respawn";
            }
            
            //Check for speed
            if (chkSpeed.Checked)
            {
                Speed = " -speed";
            }
            
            //Check for Nightmare
            if (chkNmare.Checked)
            {
                Nmare = " -nmare";
            }
            
             //Check for Nightmare 100% secrets
            if (chkNm100s.Checked)
            {
                Nm100s = " -nm100s";
            }
            
            //Check for Max
            if (chkMax.Checked)
            {
                Max = " -max";
            }
            
            //Check for pacifist
            if (chkPacifist.Checked)
            {
                Pacifist = " -pacifist";
            }
            
            //Check for tyson
            if (chkTyson.Checked)
            {
                Tyson = " -tyson";
            }
            
            //Check for movie
            if (chkMovie.Checked)
            {
                Movie = " -movie";
            }
            
            //Check for episode
            if (chkEpisode.Checked)
            {
                Episode = " -episode " + Episode_value.Value;
            }
            
            //Check if have arguments
            if (txtArg.Text.Length > 0)
            {
                Arg = " " + txtArg.Text;
            }
            //Check for turbo
            if (chkTurbo.Checked)
            {
                Turbo = " -turbo " + Turbo_value.Value;
            }

            //Check for demo play or record
            if (chkdemo.Checked)
            {
                if (Demo == iDemo.Record)
                {
                    ddemo = " -record " + Quote + txtRecord.Text + Quote;
                }

                if (Demo == iDemo.Play)
                {
                    ddemo = " -playdemo " + txtPlay.Text;
                }
            }

            //Check for Quickstart
            if (chkQSdelay.Checked)
            {
                QSdelay = " -quickstart " + QSdelay_value.Value;
            }

            //Check for printstats
            if (chkStats.Checked)
            {
                Stats = " -printstats";
            }

               //Check for server IP
            if (chkConnectTo.Checked)
            {
                ConnectTo = " -connect";
            }
            
            if (PWAD_list.CheckedIndices.Count > 0)
            {
            
            
                p.StartInfo.Arguments = iWad + " -file " + BuildPWadList(PWAD_list) + Level + iSkill +
                    nosfx + nMusic + nSound + noMonsters + fast + Respawn + Speed + Nmare + Max + Nm100s + Pacifist + Tyson + Movie + Turbo + ddemo + QSdelay + ConnectTo + Stats + Arg;
            }
            else
            {
                p.StartInfo.Arguments = iWad + Level + iSkill + nosfx + nMusic + nSound
                    + noMonsters + fast + Respawn + Speed + Nmare + Max + Nm100s + Pacifist + Tyson + Movie + Turbo + ddemo + QSdelay + ConnectTo + Stats + Arg;
            }

            try
            {
                //Start process
                p.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetWads(string filename)
        {
            byte[] bHeader = new byte[4];
            string Header;

            using (BinaryReader br = new BinaryReader(File.OpenRead(filename)))
            {
                bHeader = br.ReadBytes(4);
                br.Close();
            }
            //Convert bytes to string
            Header = Encoding.Default.GetString(bHeader);
            //Return true if we have IWAD
            return !Header.Equals("IWAD");
        }

        private bool IsIWad(string filename)
        {
            byte[] bHeader = new byte[4];
            string Header;

            using (BinaryReader br = new BinaryReader(File.OpenRead(filename)))
            {
                bHeader = br.ReadBytes(4);
                br.Close();
            }
            //Convert bytes to string
            Header = Encoding.Default.GetString(bHeader);
            //Return true if we have IWAD
            return Header.Equals("IWAD");
        }

        private void LoadWads(string pathname)
        {
            string[] Files;
            FileInfo fi;
            //Check if pathname is found
            IWAD_list.Items.Clear();
            PWAD_list.Items.Clear();
            IWads.Clear();

            if (Directory.Exists(pathname))
            {
                Files = Directory.GetFiles(pathname, "*.wad");
                
                foreach (string iWad in Files)
                {
                    fi = new FileInfo(iWad);

                    if (IsIWad(iWad))
                    {
                        //Add iwad file to list
                        IWads.Add(fi.Name);
                        //Add iwad title to combobox
                        IWAD_list.Items.Add(Tools.GetWadTitle(fi.Name));
                    }
                    //Check for custom pwads
                    if (GetWads(iWad))
                    {
                        //Add normal wads to listbox
                        PWAD_list.Items.Add(fi.Name);
                    }
                }
            }
            IWAD_list.SelectedIndex = -1;
            cboLevel.SelectedIndex = -1;
        }

        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            //Set ini filename
            cINI.INIFilename = Path.Combine(Application.StartupPath, "srcdlaunch.cfg");
            //Add skills
            cboSkill.Items.Add("1 - I'm too young to die");
            cboSkill.Items.Add("2 - Hey, not too rough");
            cboSkill.Items.Add("3 - Hurt me plenty");
            cboSkill.Items.Add("4 - Ultra-Violence");
            cboSkill.Items.Add("5 - Nightmare!");
            cboSkill.SelectedIndex = GetSkillIndex();

            //Load ini
            Tools.Port = ini.GetValue("main", "port", "");
            Tools.DataFiles = ini.GetValue("main", "data", "");
            txtArg.Text = ini.GetValue("main", "arg", "");
            txtRecord.Text = ini.GetValue("main", "record", "");
            txtPlay.Text = ini.GetValue("main", "play", "");
            ServerIP.Text = ini.GetValue("main", "server_ip", "");

            this.Cursor = Cursors.WaitCursor;
            //Load Iwads
            LoadWads(Tools.DataFiles);
            this.Cursor = Cursors.Default;

            //Set the main wad index
            try     { IWAD_list.SelectedIndex = GetIWadIndex(); }
            catch   { IWAD_list.SelectedIndex = -1; }
            
            //Set not sound checkbox
            try     { chkSound.Checked = Convert.ToBoolean(ini.GetValue("main", "sound", "true")); }
            catch   { chkSound.Checked = true; }
            //Set sound effects
            try     { chkeffects.Checked = Convert.ToBoolean(ini.GetValue("main", "effects", "true")); }
            catch   { chkeffects.Checked = true; }

            //Set no music checkbox
            try     { chkmusic.Checked = Convert.ToBoolean(ini.GetValue("main", "music", "false")); }
            catch   { chkmusic.Checked = true; }
            //Check for no monsters
            try     { chkNomonsters.Checked = Convert.ToBoolean(ini.GetValue("main", "nomonsters", "")); }
            catch   { chkNomonsters.Checked = false; }

            //Set fast monsters checkbox
            try     { chkFast.Checked = Convert.ToBoolean(ini.GetValue("main", "fast", "")); }
            catch   { chkFast.Checked = false; }
            
            //Check for Respawning monsters
            try     { chkRespawn.Checked = Convert.ToBoolean(ini.GetValue("main", "respawn", "")); }
            catch   { chkRespawn.Checked = false; }

            try     { chkSpeed.Checked = Convert.ToBoolean(ini.GetValue("main", "speed", "")); }
            catch   { chkSpeed.Checked = false; }
            
            try     { chkNmare.Checked = Convert.ToBoolean(ini.GetValue("main", "nmare", "")); }
            catch   { chkNmare.Checked = false; }
            
            try     { chkMax.Checked = Convert.ToBoolean(ini.GetValue("main", "max", "")); }
            catch   { chkMax.Checked = false; }
            
            try     { chkNm100s.Checked = Convert.ToBoolean(ini.GetValue("main", "nm100s", "")); }
            catch   { chkNm100s.Checked = false; }
            
            try     { chkPacifist.Checked = Convert.ToBoolean(ini.GetValue("main", "pacifist", "")); }
            catch   { chkPacifist.Checked = false; }
            
            try     { chkTyson.Checked = Convert.ToBoolean(ini.GetValue("main", "tyson", "")); }
            catch   { chkTyson.Checked = false; }
            
            try     { chkMovie.Checked = Convert.ToBoolean(ini.GetValue("main", "movie", "")); }
            catch   { chkMovie.Checked = false; }
            
            try     { chkEpisode.Checked = Convert.ToBoolean(ini.GetValue("main", "episode", "")); }
            catch   { chkEpisode.Checked = false; }
            
            try     { Episode_value.Value = Convert.ToInt32(ini.GetValue("main", "episode_value", "1")); }
            catch   { Episode_value.Value = 1; }
            
            //Set level index
            try     {  cboLevel.SelectedIndex = GetLevelIndex(); }
            catch   {  cboLevel.SelectedIndex = -1; }
            
            //Check for turbo boost
            try     {  chkTurbo.Checked = Convert.ToBoolean(ini.GetValue("main", "turbo", "")); }
            catch   {  chkTurbo.Checked = false; }
            //lblturbo.Enabled = chkTurbo.Checked;
            Turbo_value.Enabled = chkTurbo.Checked;
            
            //Get Turbo val
            try     { Turbo_value.Value = Convert.ToInt32(ini.GetValue("main", "turbo_value", "100")); }
            catch   { Turbo_value.Value = 100; }

            //Check for Quickstart delay
            try     { chkQSdelay.Checked = Convert.ToBoolean(ini.GetValue("main", "qsdelay", "true")); }
            catch   { chkQSdelay.Checked = true; }

            //Get Quickstart delay value
            try     { QSdelay_value.Value = Convert.ToInt32(ini.GetValue("main", "qsdelay_value", "1500")); }
            catch   { QSdelay_value.Value = 1500; }

            //Check for printstats
            try     { chkStats.Checked = Convert.ToBoolean(ini.GetValue("main", "stats", "")); }
            catch   { chkStats.Checked = false; }
            
            //Check for Connect to
            try     { chkConnectTo.Checked = Convert.ToBoolean(ini.GetValue("main", "connect_to", "")); }
            catch   { chkConnectTo.Checked = false; }
            
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmPort frm = new frmPort();
            frm.ShowDialog();

            if (Tools.ButtonPress == 1)
            {
                //Save ini file data
                ini.SetValue("main", "port", Tools.Port);
                ini.SetValue("main", "data", Tools.DataFiles);
                //Load Iwads
                LoadWads(Tools.DataFiles);
            }
        }

        private void IWAD_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            iWad = " -iwad " + Quote + Tools.DataFiles + IWads[IWAD_list.SelectedIndex] + Quote;
            //Load levels
            SetDoomMaps(IWads[IWAD_list.SelectedIndex]);
        
        
        }

        
        private void cboSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            iSkill = " -skill " + (cboSkill.SelectedIndex + 1);
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.SetValue("main", "skill", cboSkill.SelectedIndex.ToString());
            ini.SetValue("main", "iwad", IWAD_list.SelectedIndex.ToString());
            ini.SetValue("main", "level", cboLevel.SelectedIndex.ToString());

            ini.SetValue("main", "sound", chkSound.Checked.ToString());
            ini.SetValue("main", "effects", chkeffects.Checked.ToString());
            ini.SetValue("main", "music", chkmusic.Checked.ToString());

            ini.SetValue("main", "nomonsters", chkNomonsters.Checked.ToString());
            ini.SetValue("main", "speed", chkSpeed.Checked.ToString());
            ini.SetValue("main", "max", chkMax.Checked.ToString());
            ini.SetValue("main", "nmare", chkNmare.Checked.ToString());
            ini.SetValue("main", "nm100s", chkNm100s.Checked.ToString());
            ini.SetValue("main", "pacifist", chkPacifist.Checked.ToString());
            ini.SetValue("main", "tyson", chkTyson.Checked.ToString());
            ini.SetValue("main", "movie", chkMovie.Checked.ToString());
            
            ini.SetValue("main", "fast", chkFast.Checked.ToString());
            ini.SetValue("main", "respawn", chkRespawn.Checked.ToString());

            ini.SetValue("main", "episode", chkEpisode.Checked.ToString());
            ini.SetValue("main", "episode_value", Episode_value.Value.ToString());
            
            ini.SetValue("main", "turbo", chkTurbo.Checked.ToString());
            ini.SetValue("main", "turbo_value", Turbo_value.Value.ToString());

            ini.SetValue("main", "qsdelay", chkQSdelay.Checked.ToString());
            ini.SetValue("main", "connect_to", chkConnectTo.Checked.ToString());
            ini.SetValue("main", "qsdelay_value", QSdelay_value.Value.ToString());
            ini.SetValue("main", "stats", chkStats.Checked.ToString());
            ini.SetValue("main", "arg", txtArg.Text);
            ini.SetValue("main", "record", txtRecord.Text);
            ini.SetValue("main", "playdemo", txtPlay.Text);
            ini.SetValue("main", "server_ip", ServerIP.Text);
            
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtArg.Text = string.Empty;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.ShowDialog();
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            mnuNewGame_Click(sender, e);
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            //Check if port is found
            if (!File.Exists(Tools.Port))
            {
                MessageBox.Show("Doom port cannot be found.", "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (IWAD_list.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select IWAD to play.", "IWAD Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (chkdemo.Checked)
            {
                //Check name for recording demo
                if (Demo == iDemo.Record)
                {
                    if (txtRecord.Text.Length == 0)
                    {
                        MessageBox.Show("You need to enter a name to record a demo.","Demo Name Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                //Check for play demo filename
                if (Demo == iDemo.Play)
                {
                    if (txtPlay.Text.Length == 0)
                    {
                        MessageBox.Show("You need to enter a name to play a demo.", "Demo Name Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            //Start new game
            RunDoom();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            //Starts a game with a new random level
            mnuRandom_Click(sender, e);
        }

        private void mnuRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int OldLevel = cboLevel.SelectedIndex;
            //Get random level
            cboLevel.SelectedIndex = rnd.Next(cboLevel.Items.Count);
            //Start new game
            cmdNewGame_Click(sender, e);
            //Restore old index
            cboLevel.SelectedIndex = OldLevel;
        }

        private void chkdemo_CheckedChanged(object sender, EventArgs e)
        {
            optRecord.Enabled = chkdemo.Checked;
            txtRecord.Enabled = chkdemo.Checked;
            optPlay.Enabled = chkdemo.Checked;
            txtPlay.Enabled = chkdemo.Checked;
            cmdOpen.Enabled = chkdemo.Checked;
            cmdSave.Enabled = chkdemo.Checked;
            chkQSdelay.Checked = optRecord.Checked;
            chkQSdelay.Enabled = optRecord.Checked;
            QSdelay_value.Enabled = optRecord.Checked;
        }
        
        private void chkConnectTo_CheckedChanged(object sender, EventArgs e)
        {
            ServerIP.Enabled = chkConnectTo.Checked;
        }
        
        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save";
            sfd.Filter = "Demo Files(*.lmp)|*.lmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtRecord.Text = sfd.FileName;
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Demo Files(*.lmp)|*.lmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPlay.Text = ofd.FileName;
            }
        }

        private void optRecord_CheckedChanged(object sender, EventArgs e)
        {
            Demo = iDemo.Record;
            chkQSdelay.Checked = optRecord.Checked;
            chkQSdelay.Enabled = optRecord.Checked;
            QSdelay_value.Enabled = optRecord.Checked;
        }

        private void optPlay_CheckedChanged(object sender, EventArgs e)
        {
            Demo = iDemo.Play;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkmusic_CheckedChanged(object sender, EventArgs e)
        {

        }
     
        // Episode enables episode value
        private void chkEpisode_CheckedChanged(object sender, EventArgs e)
        {
            Episode_value.Enabled = chkEpisode.Checked;
        }

        // Episode value
        private void Episode_value_ValueChanged(object sender, EventArgs e)
        {

        }
        // quickstart enables QSdelay_value
        //private void chkQSdelay_CheckedChanged(object sender, EventArgs e)
        //{
        //QSdelay_value.Enabled = chkQSdelay.Checked;
        //}
     
        // turbo enables Turbo_value
        private void chkTurbo_CheckedChanged(object sender, EventArgs e)
        {
            // lblturbo.Enabled = chkTurbo.Checked;
            Turbo_value.Enabled = chkTurbo.Checked;
        }

        // turbo value
        private void Turbo_value_ValueChanged(object sender, EventArgs e)
        {

        }
        // quickstart enables QSdelay_value
        //private void chkQSdelay_CheckedChanged(object sender, EventArgs e)
        //{
        //QSdelay_value.Enabled = chkQSdelay.Checked;
        //}
     
        // quiskstart value
        private void chkQSdelay_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void chkeffects_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }     
    }
}
