using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Obstacle
    {
        public Rectangle Position;
        private int width = 40;
        private int height = 40;
        private DateTime spawnTime;

        public Obstacle(Point position)
        {
            Position = new Rectangle(position, new Size(width, height));
            spawnTime = DateTime.Now;
        }

        public void Draw(Graphics g)
        {
            // Use the crate image from resources
            Image obstacleImage = Properties.Resources.crate;

            // Draw the obstacle image at the specified position
            g.DrawImage(obstacleImage, Position);
        }

        public bool ShouldDisappear()
        {
            // Check if 10 seconds have passed since the obstacle was spawned
            return (DateTime.Now - spawnTime).TotalSeconds >= 10;
        }
    }
}
