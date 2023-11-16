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
using Snake.Properties;

namespace Snake
{
    public partial class SettingsForm : Form
    {
        private StartScreen startScreen;

        public SettingsForm(StartScreen startScreen)
        {
            InitializeComponent();
            this.startScreen = startScreen;

            // Set the music switch to ON initially
            musicSwitch.Checked = GameSettings.BackgroundMusicEnabled;
            clickSoundSwitch.Checked = GameSettings.ClickSoundEnabled;
            gameSoundSwtich.Checked = GameSettings.GameSoundEnabled;

            // Handle the initial state
            musicSwitch_CheckedChanged(null, null);
            clickSoundSwitch_CheckedChanged(null, null);
        }

        private void musicSwitch_CheckedChanged(object sender, EventArgs e)
        {
            GameSettings.BackgroundMusicEnabled = musicSwitch.Checked;
            if (musicSwitch.Checked)
            {
                SoundManager.PlayBackgroundMusic();
            }
            else
            {
                // If the switch is unchecked (music should stop), stop the background music, and update the state.
                SoundManager.StopBackgroundMusic();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            startScreen.Show();
            this.Close();
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


        private void clickSoundSwitch_CheckedChanged(object sender, EventArgs e)
        {
            GameSettings.ClickSoundEnabled = clickSoundSwitch.Checked;
            if (clickSoundSwitch.Checked)
            {
                // If the switch is checked, create the clickSoundPlayer
                SoundManager.clickSoundPlayer = new SoundPlayer(Properties.Resources.blipSelect);
            }
            else
            {
                // If the switch is unchecked, set clickSoundPlayer to null
                SoundManager.clickSoundPlayer = null;
            }
        }

              

        private void gameSoundSwitch_Click(object sender, EventArgs e)
        {
            // Toggle the game music on or off based on the switch state
            GameSettings.GameSoundEnabled = gameSoundSwtich.Checked;
            if (gameSoundSwtich.Checked)
            {
                // If the switch is checked, create the gameMusicPlayer
                SoundManager.gameMusicPlayer = new SoundPlayer(Resources.bgGame);
            }
            else
            {
                // If the switch is unchecked, set gameMusicPlayer to null
                SoundManager.gameMusicPlayer = null;
            }
        }
    }
}







