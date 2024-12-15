using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    public class Food : Organism
    {
        public int NutritionValue { get; set; }

        public Food(int x, int y, int speed, int hungerLevel, int energy,
            int visionRadius, Color color, int nutritionValue)
            : base(x, y, speed, hungerLevel, energy, visionRadius, color)
        {
            NutritionValue = nutritionValue;
        }
    }
}
