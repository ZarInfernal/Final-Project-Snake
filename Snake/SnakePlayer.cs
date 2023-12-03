using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Snake
{
    class SnakePlayer
    {
        public Rectangle[] Body;
        public int speed = 20;

        public enum Direction { Up, Down, Left, Right, NONE };
        public Direction direction;
        LinearGradientBrush bodyGradient = new LinearGradientBrush(new Point(0, 0), new Point(0, 20), Color.FromArgb(255, 204, 0), // tail color
        Color.FromArgb(255, 87, 51)); // head color

        // Head color
        SolidBrush headColor = new SolidBrush(Color.Blue);
        // Outline 
        Pen outlinePen = new Pen(Color.Black, 2);
        private int x = 240;
        private int y = 400;
        public int width = 20;
        public int height = 20;

        public SnakePlayer()
        {
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x, y, width, height);
        }

        public void UpdateBody()
        {
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];

        }


        public void Draw(Graphics g)
        {
            for (int i = 0; i < Body.Length; i++)
            {

                // Draw outline
                g.DrawEllipse(outlinePen, Body[i].X, Body[i].Y, Body[i].Width, Body[i].Height);

                // Fill with gradient 
                g.FillEllipse(bodyGradient, Body[i]);
            }

            // Draw head
            g.FillEllipse(headColor, Body[0]);
        }

        public void Grow()
        {
            List<Rectangle> bodyAdd = Body.ToList();
            bodyAdd.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height)); // add Rectangle to list
            Body = bodyAdd.ToArray();
        }

        public void Move()
        {
            UpdateBody();
            switch (direction)
            {
                case Direction.Up:
                    Body[0].Y -= speed;
                    break;
                case Direction.Down:
                    Body[0].Y += speed;
                    break;
                case Direction.Left:
                    Body[0].X -= speed;
                    break;
                case Direction.Right:
                    Body[0].X += speed;
                    break;
                case Direction.NONE:
                    Body[0].X += 0;
                    Body[0].Y += 0;
                    break;
                default:
                    break;
            }

        }
    }
}
