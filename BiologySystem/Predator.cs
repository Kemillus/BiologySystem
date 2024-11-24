using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    internal class Predator : Herbivore
    {
        public int HuntEfficiency { get; set; }
        public Predator(int x, int y, int speed, Color color, int hungerLevel, int energy, int hunterEfficiency)
            : base(x, y, speed, color, hungerLevel, energy)
        {
            HuntEfficiency = hungerLevel;
        }

        public void Hunt(Herbivore herbivore)
        {
            if (Math.Abs(X - herbivore.X) < 5 && Math.Abs(Y - herbivore.Y) < 5)
            {
                Energy += herbivore.Energy;
                HungerLevel -= herbivore.Energy;
            }
            else
            {
                X += (herbivore.X - X) / HuntEfficiency;
                Y += (herbivore.Y - Y) / HuntEfficiency;
            }
        }
    }
}
