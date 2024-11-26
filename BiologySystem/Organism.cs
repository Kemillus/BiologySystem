using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    public class Organism
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
        private int alpha = 255;
        private Random rand = new Random();
        public Organism(int x, int y, int speed, Color color)
        {
            X = x;
            Y = y;
            Speed = speed;
            Color = color;
        }

        public virtual void Move(int formWidth, int formHeight)
        {
            //var rand = new Random();
            if (-Speed > Speed)
            {
                return;
            }
            Y += rand.Next(-Speed, Speed);
            X += rand.Next(-Speed, Speed);
            if (X < 0)
            {
                X = 0;
                Speed = -Speed;
            }
            if (X > formWidth)
            {
                X = formWidth;
                Speed = -Speed;
            }
            if (Y < 0)
            {
                Y = 0;
                Speed = -Speed;
            }
            if (Y > formHeight)
            {
                Y = formHeight;
                Speed = -Speed;
            }
        }

        public virtual void Draw(Graphics g)
        {
            var brush = new SolidBrush(Color);
            g.FillEllipse(brush, X, Y, 10, 10);
        }

        public virtual void Dead()
        {
            if (alpha > 0)
            {
                alpha -= 5;
                if (alpha < 0) alpha = 0;
            }
        }
    }
}
