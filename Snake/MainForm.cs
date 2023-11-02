    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Media;

    namespace Snake
    {
        public partial class MainForm : Form
        {
        private StartScreen startScreen;
        private SoundPlayer bgMusicPlayer;
        private SoundPlayer bgGamePlayer;
        private bool IsGameMusicEnabled = true;


        public MainForm(StartScreen startScreen)
        {
            InitializeComponent();

            // Initialize SoundPlayer instances with audio files
            bgMusicPlayer = new SoundPlayer(Properties.Resources.bgForm); // The original background music
            bgGamePlayer = new SoundPlayer(Properties.Resources.bgGame); // New background audio for the game

            this.startScreen = startScreen; // Initialize the startScreen variable
        }



        public void btnStartGame_Click(object sender, EventArgs e)
        {
            // Stop the background music
            bgMusicPlayer.Stop();

            // Start the game background audio if enabled
            if (IsGameMusicEnabled)
            {
                bgGamePlayer.PlayLooping();
            }
        }

        private void customTitleBar_Paint(object sender, PaintEventArgs e)
            {

            }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startScreen != null)
            {
                // Stop the game background audio
                bgGamePlayer.Stop();

                // Start the background music
                bgMusicPlayer.PlayLooping();

                // Redirect to the home page
                startScreen.Show(); 
                this.Hide();
            }
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

        }


    }