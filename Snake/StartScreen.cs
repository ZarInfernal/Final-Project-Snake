﻿using System;
using System.Media; // Add this namespace for SoundPlayer
using System.Windows.Forms;

namespace Snake
{
    public partial class StartScreen : Form
    {
        public static SoundPlayer backgroundMusicPlayer;
        public SoundPlayer clickSoundPlayer;

        public static bool isMusicPlaying = false;

        public StartScreen()
        {
            InitializeComponent();
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnExit.FlatStyle = FlatStyle.Flat;

            // Remove border lines from all the buttons
            btnPlay.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this); 
            mainForm.Show();
            this.Hide();
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
            this.Hide();

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

            this.Hide();
            Environment.Exit(0);
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            if (backgroundMusicPlayer == null)
            {
                // Initialize the background music player using the resource
                backgroundMusicPlayer = new SoundPlayer(Properties.Resources.bgForm);

                // Start playing the background music in a loop
                backgroundMusicPlayer.PlayLooping();
                StartScreen.isMusicPlaying = true; // Music is initially playing
            }

            clickSoundPlayer = new SoundPlayer(Properties.Resources.blipSelect);

        }

        private void StartScreen_Click(object sender, EventArgs e)
        {
            if (clickSoundPlayer != null)
            {
                // Play the click sound when the form is clicked
                clickSoundPlayer.Play();
            }
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Stop the background music when the form is closed
            backgroundMusicPlayer.Stop();
            base.OnFormClosing(e);
        }
    }
}
