﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Snake.Properties;


namespace Snake
{
    public partial class MainForm : Form
    {
        // Game Stuff
        private StartScreen startScreen;
        private bool isGameStarted = false;

        // Player
        private SnakePlayer snake;

        //Food
        private Food food;

        //Score
        private int score = 0;
        private int allTimeHighScore = 0;
        private int currentPlayerHighScore = 0;

        //Snake Health
        private int snakeHealth = 3;


        //Levels
        private int currentLevel = 1;
        private int[] levelThresholds = { 20, 30, 50 };
        private Color[] levelColors = { Color.LightBlue, Color.LightGreen, Color.LightPink };




        public MainForm(StartScreen startScreen)
        {
            InitializeComponent();

            // Initialize instances with new audio
            SoundManager.InitializeBackgroundMusic();

            this.startScreen = startScreen; // Initialize the startScreen variable

            snake = new SnakePlayer();
            snake.Body[0].X = 999;

            directionTimer.Start();
            directionTimer.Interval = 100;// Change/Move Later
            food = new Food();
            lblScore.Text = "SCORE: 0";
            lblPlayerHighScore.Text = "PLAYER HIGH SCORE: 0";
            lblHighScore.Text = "HIGH SCORE: 0";
           //To Update All Time High Score
            LoadAllTimeHighScore();
            LoadGameSettings();
        }

        private void LoadGameSettings()
        {
            if (isGameStarted)
            {
                if(!SoundManager.gameMusicPlayer.IsLoadCompleted)
                {
                    SoundManager.gameMusicPlayer.Load();
                }
                if (GameSettings.GameSoundEnabled)
                    SoundManager.PlayGameMusic();
                SoundManager.StopBackgroundMusic();
            }
            else if (!GameSettings.GameSoundEnabled || !isGameStarted)
            {
                SoundManager.StopGameMusic();
                if (GameSettings.BackgroundMusicEnabled)
                    SoundManager.PlayBackgroundMusic();
            }
        }


        private void GenerateFood()
        {
            Random random = new Random();
            int x = random.Next(0, pictureBox1.Width - food.Position.Width);
            int y = random.Next(0, pictureBox1.Height - food.Position.Height);
            food.Position.Location = new Point(x, y);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Stop the background music
            SoundManager.StopBackgroundMusic();


            // Reset the game state
            snake = new SnakePlayer();
            directionTimer.Start();
            GenerateFood(); // Generate initial food position
            score = 0; // Reset the score
            UpdateScoreLabel(); // Update the score label
            UpdatePlayerHighScoreLabel(); // Update the player's high score label
            pictureBox1.Invalidate();

            // Start the game background audio if enabled
            isGameStarted = true;
            LoadGameSettings();

        }



        private void CheckCollisions()
        {
            if (!isGameStarted)
            {
                return; // Do not check collisions if the game has not started
            }

            // Check for collisions with the snake's own body
            for (int i = 1; i < snake.Body.Length; i++)
            {
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                {
                    // Snake bit itself, handle hit
                    HandleHit();
                    return;
                }
            }

            if (snake.Body[0].IntersectsWith(food.Position))
            {
                snake.Grow();
                GenerateFood(); // Generate new food after eating
                score++; // Increase the score
                UpdateScoreLabel();

                // Update current player's high score
                if (score > currentPlayerHighScore)
                {
                    currentPlayerHighScore = score;
                    UpdatePlayerHighScoreLabel();
                }

                // Update all-time high score
                if (score > allTimeHighScore)
                {
                    allTimeHighScore = score;
                    UpdateAllTimeHighScoreLabel();  // Call this method to update the label
                }

                // Check for level change
                CheckLevelChange();
            }

            // Check for collisions with bounds
            if (snake.Body[0].X < 0 || snake.Body[0].X >= pictureBox1.Width ||
                snake.Body[0].Y < 0 || snake.Body[0].Y >= pictureBox1.Height)
            {
                // Snake hit the bounds, handle health and game over
                HandleHit();
            }
        }


        private void CheckLevelChange()
        {
            // Check if the player reached the next level
            if (score == levelThresholds[currentLevel - 1])
            {
                currentLevel++;

                // Change the background color based on the level
                if (currentLevel <= levelColors.Length)
                {
                    pictureBox1.BackColor = levelColors[currentLevel - 1];
                }
            }

            // Set the BackColor property of hearts to match the color of pictureBox1
            heart1.BackColor = pictureBox1.BackColor;
            heart2.BackColor = pictureBox1.BackColor;
            heart3.BackColor = pictureBox1.BackColor;
        }




        private void HandleHit()
        {
            snakeHealth--; // Decrease health

            // Update hearts visibility based on remaining health
            switch (snakeHealth)
            {
                case 2:
                    heart3.Visible = false;
                    break;
                case 1:
                    heart2.Visible = false;
                    break;
                case 0:
                    heart1.Visible = false;
                    GameOver();
                    break;
            }

            // Reset the snake position after a hit
            snake = new SnakePlayer();
            GenerateFood(); // Generate initial food position
            pictureBox1.Invalidate();
        }




        private void GameOver()
        {
            directionTimer.Stop(); // Stop the timer to freeze the game
            SoundManager.PlayBackgroundMusic();   // Stop the game background audio

            // Show a game over message box
            MessageBox.Show("Game Over!", "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the game state
            snakeHealth = 3;
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;

            score = 0;
            currentLevel = 1;
            UpdateScoreLabel();

            // Reset background color to the first level color
            pictureBox1.BackColor = levelColors[0];

            // Restart the game
            directionTimer.Start();
            snake = new SnakePlayer();
            GenerateFood(); // Generate initial food position
            pictureBox1.Invalidate();
        }

        private void customTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }



        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startScreen != null)
            {
                // Stop the game background audio
                SoundManager.StopBackgroundMusic();
                SoundManager.StopGameMusic();

                // Update the background music player based on the setting
                if (GameSettings.BackgroundMusicEnabled)
                    SoundManager.PlayBackgroundMusic();

                // Redirect to the home page
                startScreen.Show();
                this.Close();
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
            food.Draw(e.Graphics);
        }

        private void directionTimer_Tick(object sender, EventArgs e)
        {
            snake.Move(); // Set the direction of the snake
            CheckCollisions();
            pictureBox1.Invalidate();

        }

        private void PauseGame()
        {
            directionTimer.Enabled = !directionTimer.Enabled; // Toggle the timer on/off for pausing
        }

        private void RestartGame()
        {
            directionTimer.Stop(); // Stop the timer
            SoundManager.StopBackgroundMusic();   // Stop the game background audio

            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to restart the game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Reset the game state
                directionTimer.Start();
                snake = new SnakePlayer();
                GenerateFood(); // Generate initial food position
                pictureBox1.Invalidate();
            }
            else
            {
                // If the user chooses not to restart, resume the game
                directionTimer.Start();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
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
                case Keys.P: // Pause the game
                    PauseGame();
                    break;
                case Keys.R: // Restart the game
                    RestartGame();
                    break;
            }
        }


        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }


        private void UpdateScoreLabel()
        {
            lblScore.Text = "SCORE: " + score;
        }

        private void UpdatePlayerHighScoreLabel()
        {
            lblPlayerHighScore.Text = "PLAYER HIGH SCORE: " + currentPlayerHighScore;
        }



        private void SaveAllTimeHighScore()
        {
            string filePath = "AllTimeHighScore.txt";

            // Save the all-time high score to the text file
            System.IO.File.WriteAllText(filePath, allTimeHighScore.ToString());
        }

        private void LoadAllTimeHighScore()
        {
            string filePath = "AllTimeHighScore.txt";

            // Check if the file exists before attempting to read it
            if (System.IO.File.Exists(filePath))
            {
                // Read the content of the text file and parse it to an integer
                string content = System.IO.File.ReadAllText(filePath);
                int.TryParse(content, out allTimeHighScore);
            }

            UpdateAllTimeHighScoreLabel();
        }
        private void UpdateAllTimeHighScoreLabel()
        {
            lblHighScore.Text = "HIGH SCORE: " + allTimeHighScore;
            SaveAllTimeHighScore(); // Save the high score whenever it is updated
        }
    }
}