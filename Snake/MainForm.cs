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
using Snake.Properties;


namespace Snake
{
    public partial class MainForm : Form
    {
        #region Variables
        // Game Stuff
        private StartScreen startScreen;
        private SoundPlayer bgMusicPlayer;
        private SoundPlayer bgGamePlayer;
        
        private bool IsGameMusicEnabled = true;
        private bool isGameStarted = false;
        private bool delay = false;


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

        //Difficulty
        private int difficultyLevel;
        #endregion

        #region StartUp
        public MainForm(StartScreen startScreen)
        {
            InitializeComponent();

            // Initialize SoundPlayer instances with audio files
            bgMusicPlayer = new SoundPlayer(Resources.bgForm); // The original background music
            bgGamePlayer = new SoundPlayer(Resources.bgGame); // New background audio for the game

            this.startScreen = startScreen; // Initialize the startScreen variable

            snake = new SnakePlayer();
            snake.Body[0].X = 999;

            directionTimer.Start();
            directionTimer.Interval = 100; // Change/Move Later
            food = new Food();
            lblScore.Text = "SCORE: 0";
            lblPlayerHighScore.Text = "PLAYER HIGH SCORE: 0";
            lblHighScore.Text = "HIGH SCORE: 0";
           //To Update All Time High Score
            LoadAllTimeHighScore();

          
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //add difficulty options to the combo box
            comboBoxDiff.Items.Add("EASY");
            comboBoxDiff.Items.Add("MEDIUM");
            comboBoxDiff.Items.Add("HARD");
            comboBoxDiff.SelectedIndex = 0;

            // Set read-only mode for the combo box
            comboBoxDiff.DropDownStyle = ComboBoxStyle.DropDownList;

            // Initialize the difficulty level based on the selected item
            SetDifficultyLevel();

            // Event handler for the SelectedIndexChanged event
            comboBoxDiff.SelectedIndexChanged += ComboBoxDiff_SelectedIndexChanged;
        }

        #endregion

        #region Buttons
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Stop the background music
            bgMusicPlayer.Stop();

            // Start the game background audio if enabled
            if (IsGameMusicEnabled)
            {
                bgGamePlayer.PlayLooping();
            }

            ToggleGameMusic(Settings.Default.IsGameSoundSwitchOn);

            // Reset the game state
            snake = new SnakePlayer();
            directionTimer.Start();
            GenerateFood(); // Generate initial food position
            score = 0; // Reset the score
            UpdateScoreLabel(); // Update the score label
            UpdatePlayerHighScoreLabel(); // Update the player's high score label
            pictureBox1.Invalidate();

            isGameStarted = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startScreen != null)
            {
                // Stop the game background audio only if the game is started
                if (isGameStarted)
                {
                    bgGamePlayer.Stop();
                }

                // Redirect to the home page
                startScreen.Show();
                Close();
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
        #endregion

        #region Key Presses
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            delay = false;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(delay == true)
                return;

            delay = true;

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
                case Keys.Add: // Debug for growing Snake
                    snake.Grow();
                    break;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #region Timer Events
        private void directionTimer_Tick(object sender, EventArgs e)
        {
            snake.Move(); // Set the direction of the snake
            CheckCollisions();
            pictureBox1.Invalidate();

        }
        #endregion

        #region Game Events
        private void GameOver()
        {
            directionTimer.Stop(); // Stop the timer to freeze the game
            bgGamePlayer.Stop();   // Stop the game background audio

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

        private void PauseGame()
        {
            directionTimer.Enabled = !directionTimer.Enabled; // Toggle the timer on/off for pausing
        }

        private void RestartGame()
        {
            directionTimer.Stop(); // Stop the timer
            bgGamePlayer.Stop();   // Stop the game background audio

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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics);
            food.Draw(e.Graphics);
        }
        #endregion

        #region Difficulty
        private void SetDifficultyLevel()
        {
            switch (comboBoxDiff.SelectedItem.ToString())
            {
                case "EASY":
                    difficultyLevel = 1;
                    break;
                case "MEDIUM":
                    difficultyLevel = 2;
                    break;
                case "HARD":
                    difficultyLevel = 3;
                    break;
                default:
                    difficultyLevel = 1; // Default to EASY
                    break;
            }
        }

        private void ComboBoxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDifficultyLevel();
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
        }
        #endregion

        #region Score
        // Return the score increment based on the difficulty level
        private int GetScoreIncrement()
        {
            // Return the score increment based on the difficulty level
            switch (difficultyLevel)
            {
                case 1: // EASY
                    return 1;
                case 2: // MEDIUM
                    return 2;
                case 3: // HARD
                    return 3;
                default:
                    return 1; // Default to EASY
            }
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
        #endregion

        #region Collision
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
                score += GetScoreIncrement(); // Increase the score
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
        #endregion

        #region Pickups (Food/Powerups)
        private void GenerateFood()
        {
            Random random = new Random();

            // Generate a new random position for the food
            int x, y;
            do
            {
                x = random.Next(0, pictureBox1.Width - food.Position.Width);
                y = random.Next(0, pictureBox1.Height - food.Position.Height);
            } while (snake.Body.Any(bodyPart => bodyPart.IntersectsWith(new Rectangle(x, y, food.Position.Width, food.Position.Height))));

            food.Position.Location = new Point(x, y);
        }
        #endregion

        public void ToggleGameMusic(bool enable)
        {
            if (enable)
            {
                bgGamePlayer.PlayLooping();
                IsGameMusicEnabled = true;
            }
            else
            {
                bgGamePlayer.Stop();
                IsGameMusicEnabled = false;
            }
        }

        private void customTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}