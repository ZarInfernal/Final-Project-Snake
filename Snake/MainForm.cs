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
        // Game Stuff
        private StartScreen startScreen;
        private SoundPlayer bgMusicPlayer;
        private SoundPlayer bgGamePlayer;
        private bool IsGameMusicEnabled = true;

        // Player
        private SnakePlayer snake;

        public MainForm(StartScreen startScreen)
        {
            InitializeComponent();

            // Initialize SoundPlayer instances with audio files
            bgMusicPlayer = new SoundPlayer(Properties.Resources.bgForm); // The original background music
            bgGamePlayer = new SoundPlayer(Properties.Resources.bgGame); // New background audio for the game

            this.startScreen = startScreen; // Initialize the startScreen variable

            snake = new SnakePlayer();
            snake.Body[0].X = 999;

            directionTimer.Start();
            directionTimer.Interval = 100;// Change/Move Later

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
            snake = new SnakePlayer();
            snake.direction = SnakePlayer.Direction.Right;
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics);
        }

        private void directionTimer_Tick(object sender, EventArgs e)
        {
            snake.Move(); // Set the direction of the snake
            pictureBox1.Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) // Add more buttons in here such as a pause and other things
            {
                case Keys.Up: // Change Direction Up
                case Keys.W:
                    if (snake.direction != SnakePlayer.Direction.Down) // Add more restrictions later
                        snake.direction = SnakePlayer.Direction.Up;
                    break;
                case Keys.Down: // Change Direction Down
                case Keys.S:
                    if (snake.direction != SnakePlayer.Direction.Up) // Add more restrictions later
                        snake.direction = SnakePlayer.Direction.Down;
                    break;
                case Keys.Left: // Change Direction Left
                case Keys.A:
                    if (snake.direction != SnakePlayer.Direction.Right) // Add more restrictions later
                        snake.direction = SnakePlayer.Direction.Left;
                    break;
                case Keys.Right: // Change Direction Right
                case Keys.D:
                    if (snake.direction != SnakePlayer.Direction.Left) // Add more restrictions later
                        snake.direction = SnakePlayer.Direction.Right;
                    break;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}