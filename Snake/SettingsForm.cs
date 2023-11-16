using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SettingsForm : Form
    {
        private StartScreen startScreen;
        private SoundPlayer clickSoundPlayer;
    



        public SettingsForm(StartScreen startScreen)
        {
            InitializeComponent();
            this.startScreen = startScreen;

            // Set the music switch to ON initially
            musicSwitch.Checked = StartScreen.backgroundMusicPlayer.IsLoadCompleted;
            clickSoundSwitch.Checked = true;
            gameSoundSwtich.Checked = true;

            // Handle the initial state
            musicSwitch_CheckedChanged(null, null);
        }

        private void musicSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (musicSwitch.Checked)
            {
                // If the switch is checked (music should play), and the music is not already playing, start it.
                if (!StartScreen.isMusicPlaying)
                {
                    StartScreen.backgroundMusicPlayer.PlayLooping();
                    StartScreen.isMusicPlaying = true;
                }
            }
            else
            {
                // If the switch is unchecked (music should stop), stop the background music, and update the state.
                StartScreen.backgroundMusicPlayer.Stop();
                StartScreen.isMusicPlaying = false;
            }
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            startScreen.Show();
            this.Hide();
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


        private void clickSoundSwtich_CheckedChanged(object sender, EventArgs e)
        {
            if (clickSoundSwitch.Checked)
            {
                // If the switch is checked, create the clickSoundPlayer
                clickSoundPlayer = new SoundPlayer(Properties.Resources.blipSelect);
            }
            else
            {
                // If the switch is unchecked, set clickSoundPlayer to null
                clickSoundPlayer = null;
            }
        }

              

        private void gameSoundSwitch_Click(object sender, EventArgs e)
        {
            //// Toggle the game music on or off based on the switch state
            //if (gameSoundSwitch.Checked)
            //{
            //    MainForm.bgGamePlayer.PlayLooping(); // Play the game music
            //                                         // Save the user's preference (e.g., in settings or a variable)
            //    MainForm.IsGameMusicEnabled = true;
            //}
            //else
            //{
            //    MainForm.bgGamePlayer.Stop(); // Stop the game music
            //                                  // Save the user's preference (e.g., in settings or a variable)
            //    MainForm.IsGameMusicEnabled = false;
            //}
        }
    }
    }







