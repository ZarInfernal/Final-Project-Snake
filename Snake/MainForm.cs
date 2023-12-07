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
using System.Threading;
using System.Reflection;
//using Snake.Snake;
using System.Drawing.Imaging;

namespace Snake
{
    public partial class MainForm : Form
    {
        #region Variables
        // Game Stuff
        private StartScreen startScreen;
        private SoundPlayer bgGamePlayer;
        private HelpForm helpForm;

        private bool IsGameMusicEnabled = true;
        private bool isGameStarted = false;
        private bool delay = false;


        // Player
        private SnakePlayer snake;

        //Food
        private Food food;

        //Powerup
        private List<Powerups> activePowerups = new List<Powerups>();
        private Random random = new Random();
        public DateTime speedPowerupCollectedTime;
        private bool isPowerupActive = false;

        //Score
        private int score = 0;
        private int allTimeHighScore = 0;
        private int currentPlayerHighScore = 0;

        //Snake Health
        private int snakeHealth = 3;




        //Difficulty
        private int difficultyLevel;

        //Obstacles
        private List<Obstacle> obstacles = new List<Obstacle>();
        private System.Windows.Forms.Timer obstacleTimerForm;

        #endregion

        #region StartUp
        public MainForm(StartScreen startScreen)
        {
            InitializeComponent();

            // Initialize SoundPlayer instances with audio files
            //bgMusicPlayer = new SoundPlayer(Resources.bgForm); // The original background music
            bgGamePlayer = new SoundPlayer(Resources.bgGame); // New background audio for the game

            this.startScreen = startScreen; // Initialize the startScreen variable

            snake = new SnakePlayer();
            snake.Body[0].X = 999;

            directionTimer.Start();
            directionTimer.Interval = 100; // Change/Move Later
            food = new Food();

            random = new Random();
            //healthPowerup = new HealthPowerup();
            //speedPowerup = new SpeedPowerup();

            //powerupTimer.Interval = 6000;
            //powerupTimer.Tick += powerupTimer_Tick;
            //powerupTimer.Start();

            //powerupDuration.Interval = 5000;
            //powerupDuration.Tick += powerupDuration_Tick;

            //reduceSpeed.Interval = 8000;
            //reduceSpeed.Tick += reduceSpeed_Tick;

            //powerup = new Powerup();
            lblScore.Text = "SCORE: 0";
            lblPlayerHighScore.Text = "PLAYER HIGH SCORE: 0";
            lblHighScore.Text = "HIGH SCORE: 0";
            //To Update All Time High Score
            LoadAllTimeHighScore();

            //Obstacle Timer
            obstacleTimer = new System.Windows.Forms.Timer();
            obstacleTimer.Interval = 5000;
            obstacleTimer.Tick += obstacleTimer_Tick;


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
            startScreen.backgroundMusicThread?.Abort();
            

            // Start the game background audio
            ToggleGameMusic(Settings.Default.IsGameSoundSwitchOn);

            // Reset the game state
            snake = new SnakePlayer();
            directionTimer.Start();
            obstacleTimer.Start();
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
                startScreen.StartBackgroundMusic();
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
            if (delay == true)
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
            snake.Move();
            CheckCollisions();

            // Check for generating new powerups at random intervals
            if (!isPowerupActive && activePowerups.Count == 0 && random.Next(100) < 2) // Adjust the probability as needed
            {
                if (score >= 3)
                {
                    GenerateRandomPowerup();
                    isPowerupActive = true;
                }
            }

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





            // Restart the game
            directionTimer.Start();
            obstacleTimer.Start();
            snake = new SnakePlayer();
            GenerateFood(); // Generate initial food position
            activePowerups.Clear(); // Generate initial powerup position
            if (directionTimer.Interval == 175) directionTimer.Interval = 100;
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

            // Stop the obstacleTimer
            obstacleTimer.Stop();

            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to restart the game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Reset the game state
                directionTimer.Start();
                snake = new SnakePlayer();
                GenerateFood(); // Generate initial food position
                if (directionTimer.Interval == 175) directionTimer.Interval = 100;
                activePowerups.Clear();
                pictureBox1.Invalidate();

                // Start the obstacleTimer
                obstacleTimer.Start();
            }
            else
            {
                // If the user chooses not to restart, resume the game
                directionTimer.Start();
            }
        }


        private void GenerateObstacle()
        {
            Random random = new Random();

            int x, y;
            int obstacleSize = 30;

            do
            {
                x = random.Next(0, pictureBox1.Width - obstacleSize);
                y = random.Next(0, pictureBox1.Height - obstacleSize);
            } while (snake.Body.Any(bodyPart => bodyPart.IntersectsWith(new Rectangle(x, y, obstacleSize, obstacleSize))) ||
                     obstacles.Any(obstacle => obstacle.Position.IntersectsWith(new Rectangle(x, y, obstacleSize, obstacleSize))) ||
                     food.Position.IntersectsWith(new Rectangle(x, y, obstacleSize, obstacleSize)));

            obstacles.Add(new Obstacle(new Point(x, y)));
        }



        private void obstacleTimer_Tick(object sender, EventArgs e)
        {
            GenerateObstacle();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics);
            food.Draw(e.Graphics);

            foreach (var obstacle in obstacles)
            {
                obstacle.Draw(e.Graphics);
            }



            foreach (Powerups powerup in activePowerups)
            {
                powerup.Draw(e.Graphics);
            }
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

            }
            foreach (var obstacle in obstacles.ToList())
            {
                if (snake.Body[0].IntersectsWith(obstacle.Position))
                {
                    // Snake hit an obstacle, handle hit
                    obstacles.Remove(obstacle);
                    HandleHit();
                    return;
                }

                if (obstacle.ShouldDisappear())
                {
                    obstacles.Remove(obstacle);
                }
            }



            foreach (Powerups powerup in activePowerups.ToList())
            {
                if (snake.Body[0].IntersectsWith(powerup.Position))
                {
                    // Handle powerup collection based on its type
                    switch (powerup.Type)
                    {
                        case Powerups.PowerupType.Health:
                            snakeHealth = 3; // Increase health
                            heart1.Visible = true;
                            heart2.Visible = true;
                            heart3.Visible = true;

                            isPowerupActive = false;

                            break;
                        case Powerups.PowerupType.Speed:
                            directionTimer.Interval = 175;
                            speedPowerupCollectedTime = DateTime.Now; // Record the time when the speed powerup was collected
                            break;
                    }

                    activePowerups.Remove(powerup);
                    // Remove the collected powerup from the list
                }
            }

            if (directionTimer.Interval == 175 && DateTime.Now - speedPowerupCollectedTime > TimeSpan.FromSeconds(7))
            {
                // If 7 seconds have passed, restore the snake's speed to the default value (20)
                directionTimer.Interval = 100;
                isPowerupActive = false;
                Task.Delay(random.Next(5000, 10000)).ContinueWith(_ => GenerateRandomPowerup());
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
            Console.WriteLine("Collission Occurred");
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
            if(directionTimer.Interval == 175) directionTimer.Interval = 100;
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

        private void GenerateRandomPowerup()
        {
            Random random = new Random();
            Powerups newPowerup;

            // Maximum number of attempts to generate a powerup without overlapping with snake, food, obstacles, or other powerups
            int maxAttempts = 50;

            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                // Generate a random position for the powerup
                int x = random.Next(0, pictureBox1.Width - 20);
                int y = random.Next(0, pictureBox1.Height - 20);

                Rectangle powerupRectangle = new Rectangle(x, y, 20, 20);

                // Check if the powerup overlaps with the snake or its body
                if (snake.Body.Any(bodyPart => bodyPart.IntersectsWith(powerupRectangle)))
                    continue;

                // Check if the powerup overlaps with existing food pieces
                if (food.Position.IntersectsWith(powerupRectangle))
                    continue;

                // Check if the powerup overlaps with obstacles
                bool obstacleOverlap = false;
                for (int i = 0; i < obstacles.Count; i++)
                {
                    if (obstacles[i].Position.IntersectsWith(powerupRectangle))
                    {
                        obstacleOverlap = true;
                        break;
                    }
                }

                if (obstacleOverlap)
                    continue;

                // Check if the powerup overlaps with other active powerups
                if (activePowerups.Any(existingPowerup => existingPowerup.Position.IntersectsWith(powerupRectangle)))
                    continue;

                // If none of the checks failed, create the powerup and add it to the list
                if (snakeHealth == 3)
                {
                    Powerups.PowerupType type = Powerups.PowerupType.Speed;
                    newPowerup = new Powerups(type, new Point(x, y));
                }
                else
                {
                    Powerups.PowerupType randomType = (Powerups.PowerupType)random.Next(Enum.GetNames(typeof(Powerups.PowerupType)).Length);
                    newPowerup = new Powerups(randomType, new Point(x, y));
                }

                newPowerup.OnPowerupExpired += HandlePowerupExpired;
                activePowerups.Add(newPowerup);

                // Exit the loop since a valid powerup has been generated
                break;
            }
        }



        private void HandlePowerupExpired(Powerups expiredPowerup)
        {
            activePowerups.Clear();
            isPowerupActive = false;
        }


        #endregion

        public async void ToggleGameMusic(bool enable)
        {
            if (enable)
            {
                await Task.Run(() => bgGamePlayer.PlayLooping());
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

        
            helpForm.Show();
        }

    }
}