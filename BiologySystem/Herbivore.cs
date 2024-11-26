using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    internal class Herbivore : Organism
    {
        public int HungerLevel { get; set; }
        public int Energy { get; set; }

        public Herbivore(int x, int y, int speed, Color color, int hungerLevel, int energy)
            : base(x, y, speed, color)
        {
            HungerLevel = hungerLevel;
            Energy = energy;
        }

        public void Eat(Food food)
        {
            if (Math.Abs(X - food.X) < 5 && Math.Abs(Y - food.Y) < 5)
            {
                Energy += food.NutritionValue;
                HungerLevel -= food.NutritionValue;
                food.Dead();
            }
        }

        public void Reproduce()
        {
            if (Energy > 100)
            {
                Energy -= 50;
            }
        }
    }
}
