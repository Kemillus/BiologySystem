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
        public bool IsDead { get; set; }
        protected int alpha = 255;

        public Organism(int x, int y, int speed, Color color)
        {
            X = x;
            Y = y;
            Speed = speed;
            Color = color;
        }

        public virtual void Dead()
        {
            IsDead = true;
        }

        public double DistanceTo(Organism other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }

        public virtual void Move(int formWidth, int formHeight, List<Organism> organisms)
        {

        }

        protected void MoveRandom(int formWidth, int formHeight)
        {
            var rand = new Random();
            int absSpeed = Math.Abs(Speed);
            Y += rand.Next(-absSpeed, absSpeed);
            X += rand.Next(-absSpeed, absSpeed);
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
            if (IsDead)
            {
                alpha -= 5;
                if (alpha < 0) alpha = 0;
            }

            if (alpha > 0)
            {
                var color = Color.FromArgb(alpha, Color);
                var brush = new SolidBrush(color);
                g.FillEllipse(brush, X, Y, 10, 10);
            }
        }
    }
}
