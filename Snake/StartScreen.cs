﻿using Snake.Properties;
using System;
using System.Media; 
using System.Threading;
using System.Windows.Forms;

namespace Snake
{
    public partial class StartScreen : Form
    {
        #region Variables
        public static SoundPlayer backgroundMusicPlayer;
        public SoundPlayer clickSoundPlayer;
        public Thread backgroundMusicThread;
        public Thread clickSoundThread;

        public static bool isMusicPlaying = false;
        #endregion

        #region Startup
        public StartScreen()
        {
            InitializeComponent();
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnExit.FlatStyle = FlatStyle.Flat;

            // Remove border lines from all the buttons
            btnPlay.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
        }
        private void StartScreen_Load(object sender, EventArgs e)
        {
            if (backgroundMusicPlayer == null)
            {
                // Initialize the background music player using the resource
                backgroundMusicPlayer = new SoundPlayer(Resources.bgForm);

                // Start playing the background music in a loop if Music is on since last open
                if (Settings.Default.IsMusicSwitchOn)
                {
                    StartBackgroundMusic(); // Start playing the background music
                    isMusicPlaying = true; // Music is initially playing
                }
            }

            if (clickSoundPlayer == null)
            {
                clickSoundPlayer = new SoundPlayer(Resources.blipSelect);
            }

        }

        #endregion

        #region Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this);
           
            mainForm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the program
          
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
          
            settingsForm.Show();
            Hide();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("This is Group 8 Snake Game Project");
        }

        private void pnlButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlButtonClose_Click(object sender, EventArgs e)
        {

            Hide();
            Environment.Exit(0);
        }
        #endregion

        #region Music
        public void StartBackgroundMusic()
        {
            backgroundMusicThread = new Thread(PlayBackgroundMusic);
            backgroundMusicThread.Start();
        }

        

        private void PlayBackgroundMusic()
        {
            if (backgroundMusicPlayer != null)
            {
                backgroundMusicPlayer.PlayLooping();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Stop the background music when the form is closed
            StopAudioThreads();
            base.OnFormClosing(e);
        }

        public void StopAudioThreads()
        {
            backgroundMusicThread?.Abort();
            clickSoundThread?.Abort();
        }
        #endregion
    }
}
