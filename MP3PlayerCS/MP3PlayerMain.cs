using MP3Player;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Un4seen.Bass;


namespace MP3PlayerCS
{

    public partial class MP3PlayerMain : Form
    {

        //------------------------------------------------------------------------------//
        //   Variable Declarations                                                      //
        //------------------------------------------------------------------------------//

        int Stream = 0;
        bool isTracking = false;
        bool StopBtnPressed = false;
        String[] arr1;
        readonly OpenFileDialog OpenDlgSong = new OpenFileDialog();
        readonly TextBox TempTextBox = new TextBox();
        readonly OpenFileDialog OpenDlgPlaylist = new OpenFileDialog();
        readonly String M3UPrefix = "#EXTM3U";
        //String InfoPrefix = "#EXTINF:0,";
        readonly TextBox TempTextBox2 = new TextBox();
        readonly TextBox LoadData = new TextBox();
        readonly ListBox TmpPlyLst = new ListBox();
        readonly ListBox TmpFilLst = new ListBox();
        int Loc1;
        int Loc2;
        String UserID;
        String RegCode;
        int cntr1 = 1;
        int cntr2 = 2;
        int cntr3 = 0;
        int cntr4 = 0;
        int volLvl;
        readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string _reg = Application.StartupPath + @"\Reg.ini";


        public MP3PlayerMain()
        {
            InitializeComponent();
        }


        private void Initbass()
        {
            if (toolStripComboBox1.SelectedIndex != -1)
            {
                if (Bass.BASS_Init(toolStripComboBox1.SelectedIndex, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) { }
            }
            else
            {
                if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) { } // Use default audio device if ones not been chosen
            }
            volLvl = Convert.ToInt32(Bass.BASS_GetVolume() * 100);
            if (volLvl >= 0)
            {
                Volume.Value = volLvl;
            }
        }

        public string CleanStr1(string v)
        {
            string x = v.Replace("#EXTINF:", "").Replace("%20", " ").Replace("%5B", "[").Replace("%5D", "]").Replace("%27", "'").Replace("%28", "(").Replace("%29", ")").Replace("..\\", UserProfile + "\\Music\\").Replace("file:///", "");
            //If this part exists then WMP detected the music is in the users music library folder - however the tag is also a unix file path

            return x;
        }

        private void PlaySound()
        {
            FilePathListBox.SelectedIndex = Playlist_Listbox.SelectedIndex;
            BASSActive Status = Bass.BASS_ChannelIsActive(Stream);
            if (Status != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_Free();
                Initbass();
                //Set New Stream Here
                Stream = Bass.BASS_StreamCreateFile(FilePathListBox.GetItemText(FilePathListBox.SelectedItem), 0, 0, BASSFlag.BASS_DEFAULT);
            }
            if (Stream != 0)
            {
                Bass.BASS_ChannelPlay(Stream, false);
                Cur_track.Text = Playlist_Listbox.GetItemText(Playlist_Listbox.SelectedItem);
                Tracking.Minimum = 0;
                Tracking.Value = 0;
                Tracking.Maximum = Convert.ToInt32(Bass.BASS_ChannelGetLength(Stream));
                TrackBarTimer.Enabled = true;
                StopBtnPressed = false;
                this.Text = $"MP3 Player - {Playlist_Listbox.GetItemText(Playlist_Listbox.SelectedItem)}";
                /* 
                long len = Bass.BASS_ChannelGetLength(Stream, BASSMode.BASS_POS_BYTES);
               Double time = Bass.BASS_ChannelBytes2Seconds(Stream, len);
                */
            }

        }
        private void RemoveItem()
        {
            if (Playlist_Listbox.SelectedIndex != -1)
            {
                int Oldindex = Playlist_Listbox.SelectedIndex;
                Playlist_Listbox.Items.RemoveAt(Oldindex);
                FilePathListBox.Items.RemoveAt(Oldindex);

                if (Oldindex != 0)
                {
                    Playlist_Listbox.SelectedIndex = Oldindex - 1;
                }
                else
                {
                    if (Playlist_Listbox.Items.Count != 0)
                    {
                        Playlist_Listbox.SelectedIndex = 0;
                        FilePathListBox.SelectedIndex = Playlist_Listbox.SelectedIndex;
                    }
                }

            }
        }
        private void ShufflePlaylist()
        {
            if (Playlist_Listbox.Items.Count > 0)
            {
                Random Track = new Random();
                while (Playlist_Listbox.Items.Count >= 1)
                {
                    int RdnVal = Track.Next(0, Playlist_Listbox.Items.Count);
                    Playlist_Listbox.SelectedIndex = RdnVal;
                    FilePathListBox.SelectedIndex = RdnVal;
                    TmpPlyLst.Items.Add((string)Playlist_Listbox.SelectedItem);
                    TmpFilLst.Items.Add((string)FilePathListBox.SelectedItem);
                    RemoveItem();
                }

                for (int i = 0; i <= TmpPlyLst.Items.Count - 1; i++)
                {
                    TmpPlyLst.SelectedIndex = i;
                    TmpFilLst.SelectedIndex = i;

                    Playlist_Listbox.Items.Add((string)TmpPlyLst.SelectedItem);
                    FilePathListBox.Items.Add((string)TmpFilLst.SelectedItem);

                }
                for (int i = 0; i <= Playlist_Listbox.Items.Count - 1; i++)
                {
                    Playlist_Listbox.SelectedIndex = i;
                    if (Playlist_Listbox.GetItemText(Playlist_Listbox.SelectedItem).Contains(Cur_track.Text))
                    {
                        i = Playlist_Listbox.Items.Count - 1;
                    }
                }

                TmpPlyLst.Items.Clear();
                TmpFilLst.Items.Clear();
            }


            else
            {
                MessageBox.Show("Playlist is empty", "Nothing to Shuffle");
            }
        }
        private void SavePlaylist()
        {
            SaveFileDialog SaveDlgPlaylist = new SaveFileDialog
            {
                Filter = "M3U Playlists|*.m3u"
            };
            SaveDlgPlaylist.ShowDialog();
            String TrackLength = "0";
            try
            {
                int OldSelction = Playlist_Listbox.SelectedIndex;
                while (cntr4 < (Playlist_Listbox.Items.Count))
                {
                    TempTextBox2.AppendText("#EXTINF:" + TrackLength + "," + Playlist_Listbox.GetItemText(Playlist_Listbox.Items[cntr4]) + "\r\n" + FilePathListBox.GetItemText(FilePathListBox.Items[cntr4]) + "\r\n\r\n");
                    cntr4++;
                }
                StreamWriter SavePlaylist = new StreamWriter(SaveDlgPlaylist.FileName);
                SavePlaylist.Write(M3UPrefix + "\r\n" + TempTextBox2.Text); //This will need a complete rewrite to support propper m3u playlist file format
                SavePlaylist.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
        }
        private void OpenPlaylist()
        {
            OpenDlgPlaylist.Filter = "M3U Playlists|*.m3u";
            DialogResult result2 = OpenDlgPlaylist.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                try
                {
                    Playlist_Listbox.Items.Clear();
                    FilePathListBox.Items.Clear();
                    TempTextBox.Text = System.IO.File.ReadAllText(OpenDlgPlaylist.FileName);
                    if (TempTextBox.Lines[0].Contains("#EXTM3U"))
                    {
                        arr1 = TempTextBox.Lines;
                        while (cntr1 < (TempTextBox.Lines.Count() - 1))
                        {
                            if (arr1[cntr1].Contains("#EXTINF:0,"))
                            {
                                string str = CleanStr1(arr1[cntr1]);
                                string ext = str.Substring(0, str.LastIndexOf(",") + 1);
                                Playlist_Listbox.Items.Add(str.Replace(ext, "")); //should be compatble with wmp playlists
                                cntr1 += 3;
                            }
                            else
                            {
                                string str = CleanStr1(arr1[cntr1]);
                                string ext = str.Substring(0, str.LastIndexOf(",") + 1);
                                Playlist_Listbox.Items.Add(str.Replace(ext, ""));
                                //split finction and will be changing this the playlist to better support the artist and track name display
                                cntr1 += 2;
                            }
                            /*This section will need a new rewrite as to make sure that it can handle the propper m3u playlist file and not just the one created
							by windows media player*/
                            // MessageBox.Show(arr1[cntr1]);
                        }


                        while (cntr2 < (TempTextBox.Lines.Count() - 1))
                        {
                            // MessageBox.Show("Counter TWO is: " + arr1[cntr2] + "/n And Counter 2 Minus 1 is: " + arr1[cntr2-1]);
                            if (arr1[cntr2 - 1].Contains("#EXTINF:0,")) // if it contains a number zero after #EXTINF: then chances are that there is a blank line between each entry
                            {
                                FilePathListBox.Items.Add(CleanStr1(arr1[cntr2]));
                                cntr2 += 3;
                            }
                            else
                            {
                                // MessageBox.Show(cleanStr1(arr1[cntr2]));
                                if (CleanStr1(arr1[cntr2]).Contains("file://")) //If the playlist Cotions this string then assume that it's on a network location
                                {
                                    FilePathListBox.Items.Add(CleanStr1(arr1[cntr2]).Replace("file://", "\\\\").Replace("/", "\\"));
                                    cntr2 += 2;
                                }
                                else
                                {
                                    FilePathListBox.Items.Add(CleanStr1(arr1[cntr2]));
                                    cntr2 += 2;
                                }
                            }

                        }

                    }
                    else //needs to be changed to support more file types 
                    { //if it's playlist thats made with a text editor just load it as a single list

                        while (cntr3 < (TempTextBox.Lines.Count()))
                        {
                            Playlist_Listbox.Items.Add(TempTextBox.Lines[cntr3]);
                            FilePathListBox.Items.Add(TempTextBox.Lines[cntr3]);
                            cntr3++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print(ex.Message);
                }
            }
        }
        private void AddItem()
        {
            OpenDlgSong.Filter = ("Music Files|*.mp3;*.ogg;*.mp1;*.mp2;*.wav;*.aiff;");
            OpenDlgSong.FileName = "";
            OpenDlgSong.Multiselect = true;
            DialogResult result1 = OpenDlgSong.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                foreach (string Track in OpenDlgSong.FileNames)
                {
                    try
                    {
                        FilePathListBox.Items.Add(Track);

                        Playlist_Listbox.Items.Add(Path.GetFileName(Track));
                        if (Playlist_Listbox.SelectedIndex == -1)
                        {
                            Playlist_Listbox.SelectedIndex = Playlist_Listbox.Items.Count - 1;
                            FilePathListBox.SelectedIndex = Playlist_Listbox.SelectedIndex;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print(ex.Message);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= Bass.BASS_GetDeviceCount() - 1; i++)
            {
                toolStripComboBox1.Items.Add(Bass.BASS_GetDeviceInfo(i));
            }
            Playlist_Options.SelectedIndex = 0;  
            System.Diagnostics.Debug.WriteLine(_reg);
            if (File.Exists(_reg))
            {

                //MessageBox.Show("File Was Indeed Found");
                StreamReader Loadfile = new StreamReader(_reg);
                String[] Splitlines = Loadfile.ReadToEnd().Split(':');
                LoadData.Lines = Splitlines;

                Loc1 = Array.IndexOf(LoadData.Lines, "RegID");
                if (Loc1 != -1)
                {
                    UserID = LoadData.Lines[Loc1 + 1];
                }

                Loc2 = Array.IndexOf(LoadData.Lines, "RegCode");
                if (Loc2 != -1)
                {
                    RegCode = LoadData.Lines[Loc2 + 1];
                }
                BassNet.Registration(UserID, RegCode);
            }
            else File.CreateText(_reg);

            //  Initbass();
        }

        /* Removal of Unused Codes
		private void Convert_Image(string Path, string Name, string Ext, object sender, EventArgs e)
		{ 
		//This function may not get any more use 
		Image img = Image.FromFile(Path);
        ResXResourceWriter rsxw = new ResXResourceWriter("Name.resx"); 
        rsxw.AddResource(Name+"."+Ext,img);
        rsxw.Close();
		
		}*/

        private void Playlist_Listbox_DoubleClick(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            BASSActive PlayingStatus = Bass.BASS_ChannelIsActive(Stream);
            if (PlayingStatus != BASSActive.BASS_ACTIVE_PAUSED) // if the music is playing pause it and if it's not paused play it
            {
                Bass.BASS_ChannelPause(Stream); //Pause the stream if its not paused (if it's stoped then this wont do anything)
                this.Text = "MP3 Player - " + Playlist_Listbox.SelectedItem + " - Paused";
            }
            else
            {
                Bass.BASS_ChannelPlay(Stream, false);
                this.Text = "MP3 Player - " + Playlist_Listbox.SelectedItem;
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelSetPosition(Stream, 0);
            Bass.BASS_ChannelStop(Stream);
            this.Text = "MP3 Player";
            StopBtnPressed = true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (Playlist_Listbox.SelectedIndex >= 0)
            {
                Bass.BASS_StreamFree(Stream);
                Playlist_Listbox.SelectedIndex--; // Playlist_Listbox.SelectedIndex - 1;
                PlaySound();
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Playlist_Listbox.SelectedIndex != Playlist_Listbox.Items.Count - 1)
            {
                Bass.BASS_StreamFree(Stream); //Free the stream from memory to not continue playing music that was paused
                Playlist_Listbox.SelectedIndex++;//= Playlist_Listbox.SelectedIndex + 1;
                PlaySound();
            }
        }

        private void Btn_Eject_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Feature removed as modern systems don't have disk drives", "!!!DEPRECATED!!!");
            MessageBox.Show("Number of Devices: " + Bass.BASS_GetDeviceCount());
            for (int i = 0; i <= Bass.BASS_GetDeviceCount() - 1; i++)
            {
                MessageBox.Show("Device Info: " + Bass.BASS_GetDeviceInfo(i));
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddItem();
        }
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void Btn_Open_Playlist_Click(object sender, EventArgs e)
        {
            OpenPlaylist();
        }
        private void Btn_Shuffle_Playlist_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Shuffle Playlist","NOT YET IMPLEMENTED!");
            ShufflePlaylist();
        }
        private void Btn_Save_Playlist_Click(object sender, EventArgs e)
        {
            SavePlaylist();
        }
        private void MP3PlayerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Free ANY active streams that may be playing and turn of bass
            Bass.BASS_Free();
        }
        private void TrackBarTimer_Tick(object sender, EventArgs e)
        {
            if (isTracking == false)
            {
                if (Tracking.Value != Tracking.Maximum)
                {
                    try
                    {
                        Tracking.Value = Convert.ToInt32(Bass.BASS_ChannelGetPosition(Stream));
                    }
                    catch (Exception f)
                    { Console.WriteLine("Exception Handled " + f); }
                }
            }
            BASSActive IsEndofSong = Bass.BASS_ChannelIsActive(Stream);
            if (IsEndofSong == BASSActive.BASS_ACTIVE_STOPPED)
            {
                if (StopBtnPressed == false)
                {
                    TrackBarTimer.Enabled = false;
                    if (Playlist_Options.SelectedIndex == 2)
                    {
                        Random Rndnumber = new Random();
                        int Number = Rndnumber.Next(0, Playlist_Listbox.Items.Count); //This will make sure that it would not play the last song
                        String LastSong = Playlist_Listbox.GetItemText(Playlist_Listbox.SelectedItem);
                        if (LastSong == Playlist_Listbox.GetItemText(Playlist_Listbox.Items[Number]))
                        {
                            Number = Rndnumber.Next(0, Playlist_Listbox.Items.Count);
                        }
                        Playlist_Listbox.SelectedIndex = Number;
                        PlaySound();
                    }
                    else
                    { //Only need to check if it's the last song in the list if it's not random since it could be that the last track is chosen first

                        if (Playlist_Listbox.SelectedIndex == Playlist_Listbox.Items.Count - 1)
                        {
                            if (Playlist_Options.SelectedIndex == 0) //this should only be checked if the last track was played
                            {
                                Playlist_Listbox.SelectedIndex = 0;//if user as chosen to repeat playlist send the selected index back to 0
                                PlaySound();
                            }
                        }
                        else
                        {
                            if (Playlist_Options.SelectedIndex == 1) //if user has chosen to repeat the same song then just restart it
                            {
                                PlaySound();
                            }
                            else //play Next track if user has not chosen to repeat it
                            {
                                Btn_Next.PerformClick(); //make sure that it does not go past the playlist last track
                            }
                        }
                    }
                }
            }
        }
        private void Tracking_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                Bass.BASS_ChannelSetPosition(Stream, Tracking.Value);
                isTracking = false;
            }
            else
            {
                isTracking = true;
            }
        }
        private void Volume_Scroll(object sender, ScrollEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Bass.BASS_GetVolume());
            Bass.BASS_SetVolume(Volume.Value / 100f);
        }
        private void Play_Speed_Control_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("Not Yet Implemented", "Play Speed Control");
        }
        private void Playlist_Listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.MediaNextTrack)
            {
                Btn_Next.PerformClick();
            }

            if (e.KeyCode == Keys.MediaPreviousTrack)
            {
                Btn_Back.PerformClick();
            }

            if (e.KeyCode == Keys.MediaPlayPause)
            {
                Btn_Pause.PerformClick();
            }

            if (e.KeyCode == Keys.Space)
            {
                Btn_Pause.PerformClick();
            }

            if (e.KeyCode == Keys.Return)
            {
                Btn_Play.PerformClick();
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void openPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPlaylist();
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePlaylist();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void Cur_track_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Cur_track.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}