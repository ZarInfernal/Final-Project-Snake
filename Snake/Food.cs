using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food
    {
        public Rectangle Position;
        private int width = 20;
        private int height = 20;

        public Food()
        {
            Position = new Rectangle(100, 100, width, height); // Initial position of the food
        }

        public void Draw(Graphics g)
        {
            // Use the image from resources
            Image foodImage = Properties.Resources.snakefood;

            // Draw the food image at the specified position
            g.DrawImage(foodImage, Position);
        }
    }
}
