namespace MP3PlayerCS
{
    partial class MP3PlayerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3PlayerMain));
            this.Ctrls_Panel = new System.Windows.Forms.Panel();
            this.Cur_track = new System.Windows.Forms.Label();
            this.Btn_Eject = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Sliders_Panel = new System.Windows.Forms.Panel();
            this.Volume = new System.Windows.Forms.HScrollBar();
            this.Tracking = new System.Windows.Forms.HScrollBar();
            this.Playlist_Panel = new System.Windows.Forms.Panel();
            this.Play_Speed_Control = new System.Windows.Forms.HScrollBar();
            this.Btn_Save_Playlist = new System.Windows.Forms.Button();
            this.Btn_Open_Playlist = new System.Windows.Forms.Button();
            this.Btn_Shuffle_PlayList = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Playlist_Options = new System.Windows.Forms.ComboBox();
            this.Playlist_Listbox = new System.Windows.Forms.ListBox();
            this.FilePathListBox = new System.Windows.Forms.ListBox();
            this.TrackBarTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.Ctrls_Panel.SuspendLayout();
            this.Sliders_Panel.SuspendLayout();
            this.Playlist_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ctrls_Panel
            // 
            this.Ctrls_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ctrls_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ctrls_Panel.Controls.Add(this.Cur_track);
            this.Ctrls_Panel.Controls.Add(this.Btn_Eject);
            this.Ctrls_Panel.Controls.Add(this.Btn_Next);
            this.Ctrls_Panel.Controls.Add(this.Btn_Back);
            this.Ctrls_Panel.Controls.Add(this.Btn_Stop);
            this.Ctrls_Panel.Controls.Add(this.Btn_Pause);
            this.Ctrls_Panel.Controls.Add(this.Btn_Play);
            this.Ctrls_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ctrls_Panel.Location = new System.Drawing.Point(0, 27);
            this.Ctrls_Panel.Name = "Ctrls_Panel";
            this.Ctrls_Panel.Size = new System.Drawing.Size(363, 33);
            this.Ctrls_Panel.TabIndex = 0;
            // 
            // Cur_track
            // 
            this.Cur_track.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cur_track.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cur_track.Location = new System.Drawing.Point(3, 3);
            this.Cur_track.Name = "Cur_track";
            this.Cur_track.Size = new System.Drawing.Size(217, 25);
            this.Cur_track.TabIndex = 2;
            this.Cur_track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cur_track.Click += new System.EventHandler(this.Cur_track_Click);
            // 
            // Btn_Eject
            // 
            this.Btn_Eject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Eject.FlatAppearance.BorderSize = 0;
            this.Btn_Eject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eject.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eject.Image")));
            this.Btn_Eject.Location = new System.Drawing.Point(331, 6);
            this.Btn_Eject.Name = "Btn_Eject";
            this.Btn_Eject.Size = new System.Drawing.Size(15, 15);
            this.Btn_Eject.TabIndex = 1;
            this.Btn_Eject.UseVisualStyleBackColor = true;
            this.Btn_Eject.Click += new System.EventHandler(this.Btn_Eject_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Next.FlatAppearance.BorderSize = 0;
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.Image")));
            this.Btn_Next.Location = new System.Drawing.Point(310, 6);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(15, 15);
            this.Btn_Next.TabIndex = 1;
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Back.Image")));
            this.Btn_Back.Location = new System.Drawing.Point(289, 6);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(15, 15);
            this.Btn_Back.TabIndex = 1;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Stop.FlatAppearance.BorderSize = 0;
            this.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Stop.Image")));
            this.Btn_Stop.Location = new System.Drawing.Point(268, 7);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(15, 15);
            this.Btn_Stop.TabIndex = 1;
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Pause.FlatAppearance.BorderSize = 0;
            this.Btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.Image")));
            this.Btn_Pause.Location = new System.Drawing.Point(247, 7);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(15, 15);
            this.Btn_Pause.TabIndex = 1;
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Play.Image")));
            this.Btn_Play.Location = new System.Drawing.Point(226, 6);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(15, 15);
            this.Btn_Play.TabIndex = 1;
            this.Btn_Play.UseVisualStyleBackColor = true;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // Sliders_Panel
            // 
            this.Sliders_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sliders_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sliders_Panel.Controls.Add(this.Volume);
            this.Sliders_Panel.Controls.Add(this.Tracking);
            this.Sliders_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sliders_Panel.Location = new System.Drawing.Point(0, 60);
            this.Sliders_Panel.Name = "Sliders_Panel";
            this.Sliders_Panel.Size = new System.Drawing.Size(363, 20);
            this.Sliders_Panel.TabIndex = 1;
            // 
            // Volume
            // 
            this.Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume.Location = new System.Drawing.Point(252, 2);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(105, 13);
            this.Volume.TabIndex = 2;
            this.Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Scroll);
            // 
            // Tracking
            // 
            this.Tracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tracking.Location = new System.Drawing.Point(3, 2);
            this.Tracking.Name = "Tracking";
            this.Tracking.Size = new System.Drawing.Size(242, 13);
            this.Tracking.TabIndex = 2;
            this.Tracking.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Tracking_Scroll);
            // 
            // Playlist_Panel
            // 
            this.Playlist_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Playlist_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Playlist_Panel.Controls.Add(this.Play_Speed_Control);
            this.Playlist_Panel.Controls.Add(this.Btn_Save_Playlist);
            this.Playlist_Panel.Controls.Add(this.Btn_Open_Playlist);
            this.Playlist_Panel.Controls.Add(this.Btn_Shuffle_PlayList);
            this.Playlist_Panel.Controls.Add(this.Btn_Remove);
            this.Playlist_Panel.Controls.Add(this.Btn_Add);
            this.Playlist_Panel.Controls.Add(this.Playlist_Options);
            this.Playlist_Panel.Controls.Add(this.Playlist_Listbox);
            this.Playlist_Panel.Controls.Add(this.FilePathListBox);
            this.Playlist_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playlist_Panel.Location = new System.Drawing.Point(0, 80);
            this.Playlist_Panel.Name = "Playlist_Panel";
            this.Playlist_Panel.Size = new System.Drawing.Size(363, 364);
            this.Playlist_Panel.TabIndex = 2;
            // 
            // Play_Speed_Control
            // 
            this.Play_Speed_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play_Speed_Control.Location = new System.Drawing.Point(231, 338);
            this.Play_Speed_Control.Name = "Play_Speed_Control";
            this.Play_Speed_Control.Size = new System.Drawing.Size(130, 17);
            this.Play_Speed_Control.TabIndex = 2;
            this.Play_Speed_Control.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Play_Speed_Control_Scroll);
            // 
            // Btn_Save_Playlist
            // 
            this.Btn_Save_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Save_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Save_Playlist.FlatAppearance.BorderSize = 0;
            this.Btn_Save_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save_Playlist.Image")));
            this.Btn_Save_Playlist.Location = new System.Drawing.Point(185, 338);
            this.Btn_Save_Playlist.Name = "Btn_Save_Playlist";
            this.Btn_Save_Playlist.Size = new System.Drawing.Size(15, 15);
            this.Btn_Save_Playlist.TabIndex = 3;
            this.Btn_Save_Playlist.UseVisualStyleBackColor = true;
            this.Btn_Save_Playlist.Click += new System.EventHandler(this.Btn_Save_Playlist_Click);
            // 
            // Btn_Open_Playlist
            // 
            this.Btn_Open_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Open_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Open_Playlist.FlatAppearance.BorderSize = 0;
            this.Btn_Open_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Open_Playlist.Image")));
            this.Btn_Open_Playlist.Location = new System.Drawing.Point(163, 338);
            this.Btn_Open_Playlist.Name = "Btn_Open_Playlist";
            this.Btn_Open_Playlist.Size = new System.Drawing.Size(20, 15);
            this.Btn_Open_Playlist.TabIndex = 3;
            this.Btn_Open_Playlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Open_Playlist.UseVisualStyleBackColor = true;
            this.Btn_Open_Playlist.Click += new System.EventHandler(this.Btn_Open_Playlist_Click);
            // 
            // Btn_Shuffle_PlayList
            // 
            this.Btn_Shuffle_PlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Shuffle_PlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Shuffle_PlayList.FlatAppearance.BorderSize = 0;
            this.Btn_Shuffle_PlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Shuffle_PlayList.Image = global::MP3Player.Properties.Resources.SHUFFLE;
            this.Btn_Shuffle_PlayList.Location = new System.Drawing.Point(207, 338);
            this.Btn_Shuffle_PlayList.Name = "Btn_Shuffle_PlayList";
            this.Btn_Shuffle_PlayList.Size = new System.Drawing.Size(17, 17);
            this.Btn_Shuffle_PlayList.TabIndex = 3;
            this.Btn_Shuffle_PlayList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Shuffle_PlayList.UseVisualStyleBackColor = true;
            this.Btn_Shuffle_PlayList.Click += new System.EventHandler(this.Btn_Shuffle_Playlist_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Remove.FlatAppearance.BorderSize = 0;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Remove.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remove.Image")));
            this.Btn_Remove.Location = new System.Drawing.Point(26, 338);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(15, 15);
            this.Btn_Remove.TabIndex = 3;
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(5, 338);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(15, 15);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Playlist_Options
            // 
            this.Playlist_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Playlist_Options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Playlist_Options.FormattingEnabled = true;
            this.Playlist_Options.Items.AddRange(new object[] {
            "Repeat Playlist",
            "Repeat Track",
            "Random Track"});
            this.Playlist_Options.Location = new System.Drawing.Point(47, 336);
            this.Playlist_Options.Name = "Playlist_Options";
            this.Playlist_Options.Size = new System.Drawing.Size(110, 21);
            this.Playlist_Options.TabIndex = 2;
            // 
            // Playlist_Listbox
            // 
            this.Playlist_Listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist_Listbox.FormattingEnabled = true;
            this.Playlist_Listbox.Location = new System.Drawing.Point(5, 3);
            this.Playlist_Listbox.Name = "Playlist_Listbox";
            this.Playlist_Listbox.Size = new System.Drawing.Size(353, 316);
            this.Playlist_Listbox.TabIndex = 0;
            this.Playlist_Listbox.DoubleClick += new System.EventHandler(this.Playlist_Listbox_DoubleClick);
            this.Playlist_Listbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Playlist_Listbox_KeyDown);
            // 
            // FilePathListBox
            // 
            this.FilePathListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathListBox.FormattingEnabled = true;
            this.FilePathListBox.Location = new System.Drawing.Point(3, 4);
            this.FilePathListBox.Name = "FilePathListBox";
            this.FilePathListBox.Size = new System.Drawing.Size(354, 316);
            this.FilePathListBox.TabIndex = 0;
            this.FilePathListBox.Visible = false;
            this.FilePathListBox.DoubleClick += new System.EventHandler(this.Playlist_Listbox_DoubleClick);
            // 
            // TrackBarTimer
            // 
            this.TrackBarTimer.Tick += new System.EventHandler(this.TrackBarTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openPlaylistToolStripMenuItem,
            this.savePlaylistToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openPlaylistToolStripMenuItem
            // 
            this.openPlaylistToolStripMenuItem.Name = "openPlaylistToolStripMenuItem";
            this.openPlaylistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openPlaylistToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openPlaylistToolStripMenuItem.Text = "Open Playlist";
            this.openPlaylistToolStripMenuItem.Click += new System.EventHandler(this.openPlaylistToolStripMenuItem_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // MP3PlayerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 444);
            this.Controls.Add(this.Playlist_Panel);
            this.Controls.Add(this.Sliders_Panel);
            this.Controls.Add(this.Ctrls_Panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(379, 483);
            this.Name = "MP3PlayerMain";
            this.Text = "MP3 Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MP3PlayerMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Ctrls_Panel.ResumeLayout(false);
            this.Sliders_Panel.ResumeLayout(false);
            this.Playlist_Panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ctrls_Panel;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Panel Sliders_Panel;
        private System.Windows.Forms.Panel Playlist_Panel;
        private System.Windows.Forms.Button Btn_Save_Playlist;
        private System.Windows.Forms.Button Btn_Open_Playlist;
        private System.Windows.Forms.Button Btn_Shuffle_PlayList;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.ComboBox Playlist_Options;
        private System.Windows.Forms.Button Btn_Eject;
        private System.Windows.Forms.Label Cur_track;
        private System.Windows.Forms.Timer TrackBarTimer;
        private System.Windows.Forms.HScrollBar Volume;
        private System.Windows.Forms.HScrollBar Tracking;
        private System.Windows.Forms.HScrollBar Play_Speed_Control;
        private System.Windows.Forms.ListBox Playlist_Listbox;
        private System.Windows.Forms.ListBox FilePathListBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

