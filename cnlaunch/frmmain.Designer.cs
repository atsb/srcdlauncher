namespace CNlaunch
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl3D = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.lnlTitle2 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.txtArg = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdRandom = new System.Windows.Forms.Button();
            this.chkQSdelay = new System.Windows.Forms.CheckBox();
            this.chkStats = new System.Windows.Forms.CheckBox();
            this.QSdelay_value = new System.Windows.Forms.NumericUpDown();
            this.Turbo_value = new System.Windows.Forms.NumericUpDown();
            this.chkTurbo = new System.Windows.Forms.CheckBox();
            this.chkRespawn = new System.Windows.Forms.CheckBox();
            this.chkFast = new System.Windows.Forms.CheckBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.chkConnectTo = new System.Windows.Forms.CheckBox();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.chkSpeed = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.chkNm100s = new System.Windows.Forms.CheckBox();
            this.chkTyson = new System.Windows.Forms.CheckBox();
            this.chkPacifist = new System.Windows.Forms.CheckBox();
            this.chkMovie = new System.Windows.Forms.CheckBox();
            this.chkNomonsters = new System.Windows.Forms.CheckBox();
            this.chkNmare = new System.Windows.Forms.CheckBox();
            this.chkEpisode = new System.Windows.Forms.CheckBox();
            this.Episode_value = new System.Windows.Forms.NumericUpDown();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.txtPlay = new System.Windows.Forms.TextBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkmusic = new System.Windows.Forms.CheckBox();
            this.chkeffects = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl3D1 = new System.Windows.Forms.Label();
            this.optRecord = new System.Windows.Forms.RadioButton();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.optPlay = new System.Windows.Forms.RadioButton();
            this.groupDemo = new System.Windows.Forms.GroupBox();
            this.chkdemo = new System.Windows.Forms.CheckBox();
            this.IWAD_list = new System.Windows.Forms.ComboBox();
            this.PWAD_list = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QSdelay_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turbo_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Episode_value)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filweToolStripMenuItem,
            this.mnuGame,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filweToolStripMenuItem
            // 
            this.filweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.toolStripSeparator1,
            this.mnuClose});
            this.filweToolStripMenuItem.Name = "filweToolStripMenuItem";
            this.filweToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filweToolStripMenuItem.Text = "&File";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuSettings.Size = new System.Drawing.Size(135, 22);
            this.mnuSettings.Text = "Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mnuClose.Size = new System.Drawing.Size(135, 22);
            this.mnuClose.Text = "E&xit";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuRandom});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuGame.Size = new System.Drawing.Size(50, 20);
            this.mnuGame.Text = "Game";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuNewGame.Size = new System.Drawing.Size(187, 22);
            this.mnuNewGame.Text = "Play";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuRandom
            // 
            this.mnuRandom.Name = "mnuRandom";
            this.mnuRandom.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuRandom.Size = new System.Drawing.Size(187, 22);
            this.mnuRandom.Text = "Play random level";
            this.mnuRandom.Click += new System.EventHandler(this.mnuRandom_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(126, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // lbl3D
            // 
            this.lbl3D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3D.Location = new System.Drawing.Point(0, 24);
            this.lbl3D.Name = "lbl3D";
            this.lbl3D.Size = new System.Drawing.Size(494, 2);
            this.lbl3D.TabIndex = 1;
            this.lbl3D.Text = "label1";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle1.Location = new System.Drawing.Point(264, 29);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(126, 13);
            this.lblTitle1.TabIndex = 14;
            this.lblTitle1.Text = "Select game (IWAD):";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle3.Location = new System.Drawing.Point(264, 130);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(102, 13);
            this.lblTitle3.TabIndex = 16;
            this.lblTitle3.Text = "Select PWAD(s):";
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.Location = new System.Drawing.Point(398, 496);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(86, 24);
            this.cmdNewGame.TabIndex = 19;
            this.cmdNewGame.Text = "Play";
            this.toolTip1.SetToolTip(this.cmdNewGame, "Start game");
            this.cmdNewGame.UseVisualStyleBackColor = true;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // cboSkill
            // 
            this.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Location = new System.Drawing.Point(9, 45);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(140, 21);
            this.cboSkill.TabIndex = 3;
            this.cboSkill.SelectedIndexChanged += new System.EventHandler(this.cboSkill_SelectedIndexChanged);
            // 
            // lnlTitle2
            // 
            this.lnlTitle2.AutoSize = true;
            this.lnlTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnlTitle2.Location = new System.Drawing.Point(9, 29);
            this.lnlTitle2.Name = "lnlTitle2";
            this.lnlTitle2.Size = new System.Drawing.Size(35, 13);
            this.lnlTitle2.TabIndex = 2;
            this.lnlTitle2.Text = "Skill:";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle4.Location = new System.Drawing.Point(6, 358);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(101, 13);
            this.lblTitle4.TabIndex = 8;
            this.lblTitle4.Text = "Optional arguments:";
            this.toolTip1.SetToolTip(this.lblTitle4, "-timedemo, -fastdemo, -longtics, -bpp, -gdi, -novert ");
            // 
            // txtArg
            // 
            this.txtArg.Location = new System.Drawing.Point(6, 375);
            this.txtArg.Name = "txtArg";
            this.txtArg.Size = new System.Drawing.Size(177, 20);
            this.txtArg.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtArg, "-timedemo, -longtics, -bpp, -gdi, -novert  (see CMDLINE.TXT for more)");
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(189, 374);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(52, 23);
            this.cmdClear.TabIndex = 10;
            this.cmdClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.cmdClear, "Clear arguments");
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new System.Drawing.Point(264, 496);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(109, 24);
            this.cmdRandom.TabIndex = 18;
            this.cmdRandom.Text = "Play random level";
            this.toolTip1.SetToolTip(this.cmdRandom, "Start a new game with a random level");
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // chkQSdelay
            // 
            this.chkQSdelay.AutoCheck = false;
            this.chkQSdelay.AutoSize = true;
            this.chkQSdelay.Enabled = false;
            this.chkQSdelay.Location = new System.Drawing.Point(12, 106);
            this.chkQSdelay.Name = "chkQSdelay";
            this.chkQSdelay.Size = new System.Drawing.Size(77, 17);
            this.chkQSdelay.TabIndex = 6;
            this.chkQSdelay.Text = "Quickstart:";
            this.toolTip1.SetToolTip(this.chkQSdelay, "Delay game starting so monitor can switch resolution. Works only when recording d" +
                    "emo.");
            this.chkQSdelay.UseVisualStyleBackColor = true;
            // 
            // chkStats
            // 
            this.chkStats.AutoSize = true;
            this.chkStats.Location = new System.Drawing.Point(12, 128);
            this.chkStats.Name = "chkStats";
            this.chkStats.Size = new System.Drawing.Size(133, 17);
            this.chkStats.TabIndex = 8;
            this.chkStats.Text = "Demo stats (-printstats)";
            this.toolTip1.SetToolTip(this.chkStats, "Outputs demo statistics to stdout.txt file");
            this.chkStats.UseVisualStyleBackColor = true;
            // 
            // QSdelay_value
            // 
            this.QSdelay_value.Enabled = false;
            this.QSdelay_value.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.QSdelay_value.Location = new System.Drawing.Point(91, 104);
            this.QSdelay_value.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.QSdelay_value.Name = "QSdelay_value";
            this.QSdelay_value.Size = new System.Drawing.Size(50, 20);
            this.QSdelay_value.TabIndex = 7;
            this.toolTip1.SetToolTip(this.QSdelay_value, "0-9999");
            this.QSdelay_value.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // Turbo_value
            // 
            this.Turbo_value.Location = new System.Drawing.Point(91, 82);
            this.Turbo_value.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.Turbo_value.Name = "Turbo_value";
            this.Turbo_value.Size = new System.Drawing.Size(50, 20);
            this.Turbo_value.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Turbo_value, "0-400");
            this.Turbo_value.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Turbo_value.ValueChanged += new System.EventHandler(this.Turbo_value_ValueChanged);
            // 
            // chkTurbo
            // 
            this.chkTurbo.AutoSize = true;
            this.chkTurbo.Location = new System.Drawing.Point(12, 84);
            this.chkTurbo.Name = "chkTurbo";
            this.chkTurbo.Size = new System.Drawing.Size(57, 17);
            this.chkTurbo.TabIndex = 4;
            this.chkTurbo.Text = "Turbo:";
            this.toolTip1.SetToolTip(this.chkTurbo, "Multiplies the player\'s movement speed by a percentage.");
            this.chkTurbo.UseVisualStyleBackColor = true;
            this.chkTurbo.CheckedChanged += new System.EventHandler(this.chkTurbo_CheckedChanged);
            // 
            // chkRespawn
            // 
            this.chkRespawn.AutoSize = true;
            this.chkRespawn.Location = new System.Drawing.Point(86, 17);
            this.chkRespawn.Name = "chkRespawn";
            this.chkRespawn.Size = new System.Drawing.Size(75, 17);
            this.chkRespawn.TabIndex = 4;
            this.chkRespawn.Text = "Respawn*";
            this.toolTip1.SetToolTip(this.chkRespawn, "Respawn");
            this.chkRespawn.UseVisualStyleBackColor = true;
            // 
            // chkFast
            // 
            this.chkFast.AutoSize = true;
            this.chkFast.Location = new System.Drawing.Point(86, 80);
            this.chkFast.Name = "chkFast";
            this.chkFast.Size = new System.Drawing.Size(50, 17);
            this.chkFast.TabIndex = 7;
            this.chkFast.Text = "Fast*";
            this.toolTip1.SetToolTip(this.chkFast, "Fast");
            this.chkFast.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(199, 54);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(30, 20);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = ". . .";
            this.toolTip1.SetToolTip(this.cmdSave, "Select demo name for recording.");
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Enabled = false;
            this.cmdOpen.Location = new System.Drawing.Point(199, 99);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(30, 20);
            this.cmdOpen.TabIndex = 6;
            this.cmdOpen.Text = ". . .";
            this.toolTip1.SetToolTip(this.cmdOpen, "Select demo for playback.");
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // chkConnectTo
            // 
            this.chkConnectTo.AutoSize = true;
            this.chkConnectTo.Location = new System.Drawing.Point(12, 150);
            this.chkConnectTo.Name = "chkConnectTo";
            this.chkConnectTo.Size = new System.Drawing.Size(113, 17);
            this.chkConnectTo.TabIndex = 9;
            this.chkConnectTo.Text = "Connect to server:";
            this.toolTip1.SetToolTip(this.chkConnectTo, "Enter server address to join multiplayer or cooperative game.");
            this.chkConnectTo.UseVisualStyleBackColor = true;
            this.chkConnectTo.CheckedChanged += new System.EventHandler(this.chkConnectTo_CheckedChanged);
            // 
            // ServerIP
            // 
            this.ServerIP.Enabled = false;
            this.ServerIP.Location = new System.Drawing.Point(134, 217);
            this.ServerIP.MaxLength = 15;
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(100, 20);
            this.ServerIP.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ServerIP, "Enter IP address [xxx.xxx.xxx.xxx].");
            // 
            // chkSpeed
            // 
            this.chkSpeed.AutoSize = true;
            this.chkSpeed.Location = new System.Drawing.Point(9, 17);
            this.chkSpeed.Name = "chkSpeed";
            this.chkSpeed.Size = new System.Drawing.Size(57, 17);
            this.chkSpeed.TabIndex = 0;
            this.chkSpeed.Text = "Speed";
            this.toolTip1.SetToolTip(this.chkSpeed, "Speed");
            this.chkSpeed.UseVisualStyleBackColor = true;
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(9, 59);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(46, 17);
            this.chkMax.TabIndex = 2;
            this.chkMax.Text = "Max";
            this.toolTip1.SetToolTip(this.chkMax, "Max, 100% kills and 100%  secrets");
            this.chkMax.UseVisualStyleBackColor = true;
            // 
            // chkNm100s
            // 
            this.chkNm100s.AutoSize = true;
            this.chkNm100s.Location = new System.Drawing.Point(9, 80);
            this.chkNm100s.Name = "chkNm100s";
            this.chkNm100s.Size = new System.Drawing.Size(68, 17);
            this.chkNm100s.TabIndex = 3;
            this.chkNm100s.Text = "NM100S";
            this.toolTip1.SetToolTip(this.chkNm100s, "Nightmare 100% secrets");
            this.chkNm100s.UseVisualStyleBackColor = true;
            // 
            // chkTyson
            // 
            this.chkTyson.AutoSize = true;
            this.chkTyson.Location = new System.Drawing.Point(86, 38);
            this.chkTyson.Name = "chkTyson";
            this.chkTyson.Size = new System.Drawing.Size(55, 17);
            this.chkTyson.TabIndex = 5;
            this.chkTyson.Text = "Tyson";
            this.toolTip1.SetToolTip(this.chkTyson, "Tyson");
            this.chkTyson.UseVisualStyleBackColor = true;
            // 
            // chkPacifist
            // 
            this.chkPacifist.AutoSize = true;
            this.chkPacifist.Location = new System.Drawing.Point(86, 59);
            this.chkPacifist.Name = "chkPacifist";
            this.chkPacifist.Size = new System.Drawing.Size(60, 17);
            this.chkPacifist.TabIndex = 6;
            this.chkPacifist.Text = "Pacifist";
            this.toolTip1.SetToolTip(this.chkPacifist, "Pacifist");
            this.chkPacifist.UseVisualStyleBackColor = true;
            // 
            // chkMovie
            // 
            this.chkMovie.AutoSize = true;
            this.chkMovie.Location = new System.Drawing.Point(163, 38);
            this.chkMovie.Name = "chkMovie";
            this.chkMovie.Size = new System.Drawing.Size(55, 17);
            this.chkMovie.TabIndex = 9;
            this.chkMovie.Text = "Movie";
            this.toolTip1.SetToolTip(this.chkMovie, "Complete game run");
            this.chkMovie.UseVisualStyleBackColor = true;
            // 
            // chkNomonsters
            // 
            this.chkNomonsters.AutoSize = true;
            this.chkNomonsters.Location = new System.Drawing.Point(163, 17);
            this.chkNomonsters.Name = "chkNomonsters";
            this.chkNomonsters.Size = new System.Drawing.Size(58, 17);
            this.chkNomonsters.TabIndex = 8;
            this.chkNomonsters.Text = "Nomo*";
            this.toolTip1.SetToolTip(this.chkNomonsters, "No monsters");
            this.chkNomonsters.UseVisualStyleBackColor = true;
            // 
            // chkNmare
            // 
            this.chkNmare.AutoSize = true;
            this.chkNmare.Location = new System.Drawing.Point(9, 38);
            this.chkNmare.Name = "chkNmare";
            this.chkNmare.Size = new System.Drawing.Size(74, 17);
            this.chkNmare.TabIndex = 1;
            this.chkNmare.Text = "Nightmare";
            this.toolTip1.SetToolTip(this.chkNmare, "Nightmare");
            this.chkNmare.UseVisualStyleBackColor = true;
            // 
            // chkEpisode
            // 
            this.chkEpisode.AutoSize = true;
            this.chkEpisode.Location = new System.Drawing.Point(163, 59);
            this.chkEpisode.Name = "chkEpisode";
            this.chkEpisode.Size = new System.Drawing.Size(67, 17);
            this.chkEpisode.TabIndex = 10;
            this.chkEpisode.Text = "Episode:";
            this.toolTip1.SetToolTip(this.chkEpisode, "Episode run");
            this.chkEpisode.UseVisualStyleBackColor = true;
            this.chkEpisode.CheckedChanged += new System.EventHandler(this.chkEpisode_CheckedChanged);
            // 
            // Episode_value
            // 
            this.Episode_value.Enabled = false;
            this.Episode_value.Location = new System.Drawing.Point(171, 77);
            this.Episode_value.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Episode_value.Name = "Episode_value";
            this.Episode_value.Size = new System.Drawing.Size(50, 20);
            this.Episode_value.TabIndex = 11;
            this.toolTip1.SetToolTip(this.Episode_value, "1-4");
            this.Episode_value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Episode_value.ValueChanged += new System.EventHandler(this.Episode_value_ValueChanged);
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownHeight = 100;
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.IntegralHeight = false;
            this.cboLevel.ItemHeight = 13;
            this.cboLevel.Location = new System.Drawing.Point(167, 45);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(74, 21);
            this.cboLevel.TabIndex = 5;
            // 
            // txtPlay
            // 
            this.txtPlay.Enabled = false;
            this.txtPlay.Location = new System.Drawing.Point(3, 99);
            this.txtPlay.Name = "txtPlay";
            this.txtPlay.Size = new System.Drawing.Size(195, 20);
            this.txtPlay.TabIndex = 5;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Checked = true;
            this.chkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSound.Location = new System.Drawing.Point(12, 18);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(57, 17);
            this.chkSound.TabIndex = 1;
            this.chkSound.Text = "Sound";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMap.Location = new System.Drawing.Point(167, 29);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(35, 13);
            this.lblMap.TabIndex = 4;
            this.lblMap.Text = "Map:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.chkConnectTo);
            this.groupBox1.Controls.Add(this.chkStats);
            this.groupBox1.Controls.Add(this.QSdelay_value);
            this.groupBox1.Controls.Add(this.chkQSdelay);
            this.groupBox1.Controls.Add(this.Turbo_value);
            this.groupBox1.Controls.Add(this.chkTurbo);
            this.groupBox1.Controls.Add(this.chkmusic);
            this.groupBox1.Controls.Add(this.chkeffects);
            this.groupBox1.Controls.Add(this.chkSound);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkmusic
            // 
            this.chkmusic.AutoSize = true;
            this.chkmusic.Location = new System.Drawing.Point(29, 62);
            this.chkmusic.Name = "chkmusic";
            this.chkmusic.Size = new System.Drawing.Size(114, 17);
            this.chkmusic.TabIndex = 3;
            this.chkmusic.Text = "Background music";
            this.chkmusic.UseVisualStyleBackColor = true;
            this.chkmusic.CheckedChanged += new System.EventHandler(this.chkmusic_CheckedChanged);
            // 
            // chkeffects
            // 
            this.chkeffects.AutoSize = true;
            this.chkeffects.Checked = true;
            this.chkeffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkeffects.Location = new System.Drawing.Point(29, 40);
            this.chkeffects.Name = "chkeffects";
            this.chkeffects.Size = new System.Drawing.Size(92, 17);
            this.chkeffects.TabIndex = 2;
            this.chkeffects.Text = "Sound effects";
            this.chkeffects.UseVisualStyleBackColor = true;
            this.chkeffects.CheckedChanged += new System.EventHandler(this.chkeffects_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.Episode_value);
            this.groupBox2.Controls.Add(this.chkEpisode);
            this.groupBox2.Controls.Add(this.chkNmare);
            this.groupBox2.Controls.Add(this.chkNomonsters);
            this.groupBox2.Controls.Add(this.chkMovie);
            this.groupBox2.Controls.Add(this.chkPacifist);
            this.groupBox2.Controls.Add(this.chkTyson);
            this.groupBox2.Controls.Add(this.chkNm100s);
            this.groupBox2.Controls.Add(this.chkRespawn);
            this.groupBox2.Controls.Add(this.chkMax);
            this.groupBox2.Controls.Add(this.chkFast);
            this.groupBox2.Controls.Add(this.chkSpeed);
            this.groupBox2.Location = new System.Drawing.Point(9, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 102);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category / game mode";
            // 
            // lbl3D1
            // 
            this.lbl3D1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3D1.Location = new System.Drawing.Point(252, 32);
            this.lbl3D1.Name = "lbl3D1";
            this.lbl3D1.Size = new System.Drawing.Size(2, 490);
            this.lbl3D1.TabIndex = 13;
            this.lbl3D1.Text = "label3";
            // 
            // optRecord
            // 
            this.optRecord.AutoSize = true;
            this.optRecord.Checked = true;
            this.optRecord.Enabled = false;
            this.optRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optRecord.Location = new System.Drawing.Point(4, 33);
            this.optRecord.Name = "optRecord";
            this.optRecord.Size = new System.Drawing.Size(100, 17);
            this.optRecord.TabIndex = 1;
            this.optRecord.TabStop = true;
            this.optRecord.Text = "Record demo";
            this.optRecord.UseVisualStyleBackColor = true;
            this.optRecord.CheckedChanged += new System.EventHandler(this.optRecord_CheckedChanged);
            // 
            // txtRecord
            // 
            this.txtRecord.Enabled = false;
            this.txtRecord.Location = new System.Drawing.Point(3, 54);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(194, 20);
            this.txtRecord.TabIndex = 2;
            // 
            // optPlay
            // 
            this.optPlay.AutoSize = true;
            this.optPlay.Enabled = false;
            this.optPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optPlay.Location = new System.Drawing.Point(4, 78);
            this.optPlay.Name = "optPlay";
            this.optPlay.Size = new System.Drawing.Size(111, 17);
            this.optPlay.TabIndex = 4;
            this.optPlay.Text = "Playback demo";
            this.optPlay.UseVisualStyleBackColor = true;
            this.optPlay.CheckedChanged += new System.EventHandler(this.optPlay_CheckedChanged);
            // 
            // groupDemo
            // 
            this.groupDemo.Controls.Add(this.chkdemo);
            this.groupDemo.Controls.Add(this.cmdOpen);
            this.groupDemo.Controls.Add(this.txtPlay);
            this.groupDemo.Controls.Add(this.optPlay);
            this.groupDemo.Controls.Add(this.cmdSave);
            this.groupDemo.Controls.Add(this.txtRecord);
            this.groupDemo.Controls.Add(this.optRecord);
            this.groupDemo.ForeColor = System.Drawing.Color.Black;
            this.groupDemo.Location = new System.Drawing.Point(9, 396);
            this.groupDemo.Name = "groupDemo";
            this.groupDemo.Size = new System.Drawing.Size(232, 125);
            this.groupDemo.TabIndex = 12;
            this.groupDemo.TabStop = false;
            // 
            // chkdemo
            // 
            this.chkdemo.Location = new System.Drawing.Point(6, 12);
            this.chkdemo.Name = "chkdemo";
            this.chkdemo.Size = new System.Drawing.Size(103, 17);
            this.chkdemo.TabIndex = 12;
            this.chkdemo.Text = "Demo control:";
            this.chkdemo.UseVisualStyleBackColor = true;
            this.chkdemo.CheckedChanged += new System.EventHandler(this.chkdemo_CheckedChanged);
            // 
            // IWAD_list
            // 
            this.IWAD_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.IWAD_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IWAD_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IWAD_list.FormattingEnabled = true;
            this.IWAD_list.Location = new System.Drawing.Point(264, 45);
            this.IWAD_list.MaxDropDownItems = 10;
            this.IWAD_list.Name = "IWAD_list";
            this.IWAD_list.Size = new System.Drawing.Size(220, 85);
            this.IWAD_list.TabIndex = 15;
            this.IWAD_list.SelectedIndexChanged += new System.EventHandler(this.IWAD_list_SelectedIndexChanged);
            // 
            // PWAD_list
            // 
            this.PWAD_list.CheckOnClick = true;
            this.PWAD_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PWAD_list.FormattingEnabled = true;
            this.PWAD_list.Location = new System.Drawing.Point(264, 146);
            this.PWAD_list.Name = "PWAD_list";
            this.PWAD_list.Size = new System.Drawing.Size(220, 334);
            this.PWAD_list.Sorted = true;
            this.PWAD_list.TabIndex = 17;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 532);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.IWAD_list);
            this.Controls.Add(this.groupDemo);
            this.Controls.Add(this.lbl3D1);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtArg);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.cboSkill);
            this.Controls.Add(this.lnlTitle2);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.PWAD_list);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lbl3D);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRCD Doom launcher";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QSdelay_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turbo_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Episode_value)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupDemo.ResumeLayout(false);
            this.groupDemo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Label lbl3D;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.ComboBox cboSkill;
        private System.Windows.Forms.Label lnlTitle2;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.TextBox txtArg;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkeffects;
        private System.Windows.Forms.CheckBox chkmusic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRespawn;
        private System.Windows.Forms.CheckBox chkFast;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.CheckBox chkTurbo;
        private System.Windows.Forms.NumericUpDown Turbo_value;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Label lbl3D1;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuRandom;
        internal System.Windows.Forms.CheckedListBox PWAD_list;
        private System.Windows.Forms.RadioButton optRecord;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.RadioButton optPlay;
        private System.Windows.Forms.TextBox txtPlay;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.GroupBox groupDemo;
        private System.Windows.Forms.CheckBox chkQSdelay;
        private System.Windows.Forms.NumericUpDown QSdelay_value;
        private System.Windows.Forms.CheckBox chkStats;
        internal System.Windows.Forms.ComboBox IWAD_list;
        private System.Windows.Forms.CheckBox chkConnectTo;
        private System.Windows.Forms.CheckBox chkdemo;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.CheckBox chkNm100s;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.CheckBox chkSpeed;
        private System.Windows.Forms.CheckBox chkMovie;
        private System.Windows.Forms.CheckBox chkPacifist;
        private System.Windows.Forms.CheckBox chkTyson;
        private System.Windows.Forms.CheckBox chkNomonsters;
        private System.Windows.Forms.CheckBox chkNmare;
        private System.Windows.Forms.CheckBox chkEpisode;
        private System.Windows.Forms.NumericUpDown Episode_value;
    }
}

