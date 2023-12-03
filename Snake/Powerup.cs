using System;
using System.Drawing;
using System.Windows.Forms;


namespace Snake
{
    namespace Snake
    {
        internal class Powerups
        {
            public enum PowerupType { Health, Speed };

            public PowerupType Type { get; private set; }
            public Rectangle Position { get; private set; }
            public Image PowerupImage { get; private set; }

            private int width = 20;
            private int height = 20;

            private Timer timer;
            private int durationInSeconds;


            public Powerups(PowerupType type, Point position)
            {
                Type = type;
                Position = new Rectangle(position.X, position.Y, width, height);

                // Set the image based on the powerup type
                if (Type == PowerupType.Health)
                    PowerupImage = Properties.Resources.health_powerup;
                else if (Type == PowerupType.Speed)
                    PowerupImage = Properties.Resources.speed_powerup;

                InitializeTimer();
            }

            private void InitializeTimer()
            {
                // Ensure that the duration is greater than 0
                durationInSeconds = 10;

                timer = new Timer();
                timer.Interval = durationInSeconds * 1000; // Convert seconds to milliseconds
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                // The timer has elapsed, so remove the powerup
                timer.Stop();
                OnPowerupExpired?.Invoke(this);
            }

            public event Action<Powerups> OnPowerupExpired;

            public void Draw(Graphics g)
            {
                // Draw the powerup image at the specified position
                g.DrawImage(PowerupImage, Position);
            }
        }
    }
}