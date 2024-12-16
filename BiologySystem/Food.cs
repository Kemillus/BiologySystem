using System.Collections.Generic;
using System.Drawing;

namespace BiologySystem
{
    public class Food : Organism
    {
        public int NutritionValue { get; set; }

        public Food(int x, int y, int speed, int hungerLevel, int maxHunger, int energy, int energyForReproduce,
            int visionRadius, Color color, int lifeSpan, int nutritionValue)
            : base(x, y, speed, hungerLevel, maxHunger, energy, energyForReproduce, visionRadius, lifeSpan, color)
        {
            NutritionValue = nutritionValue;
        }

        public override void Move(int formWidth, int formHeight, List<Organism> organisms)
        {
            LifeTime += 1;
        }

        public override string ToString()
        {
            return $"NV {NutritionValue}, LT{LifeTime}";
        }
    }
}
