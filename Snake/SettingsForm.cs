using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        #region Variables
        private StartScreen startScreen;
        private MainForm mainForm;
        private SoundPlayer clickSoundPlayer;
        private CheckBox gameSoundSwitch;
        #endregion

        #region Startup
        public SettingsForm(StartScreen startScreen)
        {
            InitializeComponent();
            this.startScreen = startScreen;
            


            // Set the music switch to the value saved in settings
            musicSwitch.Checked = Settings.Default.IsMusicSwitchOn;
            clickSoundSwitch.Checked = Settings.Default.IsClickSoundSwitchOn;
            gameSoundSwtich.Checked = Settings.Default.IsGameSoundSwitchOn;

            // Handle the initial state
            musicSwitch_CheckedChanged(null, null);
            clickSoundSwtich_CheckedChanged(null, null);
            gameSoundSwtich_CheckedChanged(null, null);


        }
        #endregion

        #region Buttons
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
        #endregion

        #region Switch Checks
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

            // Update the setting when the switch changes
            Settings.Default.IsMusicSwitchOn = musicSwitch.Checked;
            Settings.Default.Save();
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

            // Update the setting when the switch changes
            Settings.Default.IsMusicSwitchOn = musicSwitch.Checked;
            Settings.Default.Save();
        }

        private void gameSoundSwtich_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the game music on or off based on the switch state
            mainForm.ToggleGameMusic(gameSoundSwitch.Checked);

            // Update the setting when the switch changes
            Settings.Default.IsGameSoundSwitchOn = gameSoundSwitch.Checked;
            Settings.Default.Save();
        }
        #endregion
    }
}







