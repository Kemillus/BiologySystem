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

        public Organism(int x, int y, int speed, Color color)
        {
            X = x;
            Y = y;
            Speed = speed;
            Color = color;
        }
        public virtual void Move()
        {
            var rand = new Random();
            Y += rand.Next(-Speed, Speed);
            X += rand.Next(-Speed, Speed);
        }
        public virtual void Draw(Graphics g)
        {
            var brush = new SolidBrush(Color);
            g.FillEllipse(brush, X, Y, 10, 10);
        }
    }
}
