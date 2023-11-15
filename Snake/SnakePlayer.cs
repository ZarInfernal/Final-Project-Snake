using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Snake
{
    class SnakePlayer
    {
        public Rectangle[] Body;
        int speed = 20;
        public enum Direction { Up, Down, Left, Right, NONE };
        public Direction direction;
        LinearGradientBrush bodyColor = new LinearGradientBrush(new Point(-10, 550), new Point(560, -10), Color.White, Color.White);
        LinearGradientBrush headColor = new LinearGradientBrush(new Point(-10, 550), new Point(560, -10), Color.Blue, Color.Blue);
        private int x = 240;
        private int y = 400;
        private int width = 20;
        private int height = 20;


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
            for (int i = Body.Length - 1; i > 0; i--)
                g.FillEllipse(bodyColor, Body[i]);

            g.FillEllipse(headColor, Body[0]);
        }

        public void Grow()
        {
            List<Rectangle> bodyAdd = Body.ToList();
            bodyAdd.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length-1].Y, width, height)); // add Rectangle to list
            Body = bodyAdd.ToArray();
        }

        public void Move()
        {
            UpdateBody();
            switch(direction)
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
