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
        
        #endregion

        #region Startup
        public SettingsForm(StartScreen startScreen)
        {
            InitializeComponent();
          
            this.startScreen = startScreen;

            
            // Set the music switch to the value saved in settings
            musicSwitch.Checked = Settings.Default.IsMusicSwitchOn;
            clickSoundSwitch.Checked = Settings.Default.IsClickSoundSwitchOn;
            gameSoundSwitch.Checked = Settings.Default.IsGameSoundSwitchOn;

            // Handle the initial state
            musicSwitch_CheckedChanged(null, null);
            clickSoundSwitch_CheckedChanged(null, null);
            gameSoundSwitch_CheckedChanged(null, null);
        }
        #endregion

        #region Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            startScreen.ButtonClick();
            startScreen.Show();
            Close();
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

        #region Switch Checks
        private void musicSwitch_CheckedChanged(object sender, EventArgs e)
        {
            startScreen.ButtonClick();
            if (musicSwitch.Checked)
            {
                // If the switch is checked (music should play), and the music is not already playing, start it.
                if (!StartScreen.isMusicPlaying)
                {
                    startScreen.StartBackgroundMusic();
                    StartScreen.isMusicPlaying = true;
                }
            }
            else
            {
                // If the switch is unchecked (music should stop), stop the background music, and update the state.
                if (StartScreen.isMusicPlaying)
                {
                    StartScreen.backgroundMusicPlayer.Stop();
                    StartScreen.isMusicPlaying = false;
                }
            }

            // Update the setting when the switch changes
            Settings.Default.IsMusicSwitchOn = musicSwitch.Checked;
            Settings.Default.Save();
        }

        private void clickSoundSwitch_CheckedChanged(object sender, EventArgs e)
        {
            startScreen.ButtonClick();
            // Update the setting when the switch changes
            Settings.Default.IsClickSoundSwitchOn = clickSoundSwitch.Checked;
            Settings.Default.Save();
        }

        private void gameSoundSwitch_CheckedChanged(object sender, EventArgs e)
        {
            startScreen.ButtonClick();
            // Update the setting when the switch changes
            Settings.Default.IsGameSoundSwitchOn = gameSoundSwitch.Checked;
            Settings.Default.Save();
        }
        #endregion

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

     
    }
}







