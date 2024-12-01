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
        public int VisionRadius { get; set; }
        private Food targetFood = null;

        public Herbivore(int x, int y, int speed, Color color, int hungerLevel, int energy, int visionRadius)
            : base(x, y, speed, color)
        {
            HungerLevel = hungerLevel;
            Energy = energy;
            VisionRadius = visionRadius;
        }

        public Food FindNearestFood(List<Organism> organisms)
        {
            Food nearestFood = null;
            double minDistance = double.MaxValue;

            foreach (var organism in organisms)
            {
                if (organism is Food food)
                {
                    double distance = DistanceTo(food);
                    if (distance < minDistance && distance <= VisionRadius)
                    {
                        minDistance = distance;
                        nearestFood = food;
                    }
                }
            }

            return nearestFood;
        }

        protected void MoveTowardsTarget(Organism target)
        {
            if (target == null) return;

            double distance = DistanceTo(target);
            if (distance > 0)
            {
                int deltaX = target.X - X;
                int deltaY = target.Y - Y;

                X += (int)(deltaX / distance * Speed);
                Y += (int)(deltaY / distance * Speed);
            }
        }

        public override void Move(int formWidth, int formHeight, List<Organism> organisms)
        {
            HungerLevel += HungerIncrease;

            if (HungerLevel >= 500)
            {
                Dead();
                return;
            }

            if (HungerLevel > 400)
            {
                Speed = 10;
            }
            else { Speed = 7; }

            targetFood = null;
            if (targetFood == null)
            {
                targetFood = FindNearestFood(organisms);
            }

            if (targetFood != null && !targetFood.IsDead)
            {
                MoveTowardsTarget(targetFood);
                if (DistanceTo(targetFood) < 5)
                {
                    Eat(targetFood);
                }
            }

            else
            {
                MoveRandom(formWidth, formHeight);
            }

            if (X < 0) { angle = Math.PI - angle; X = 0; }
            if (X > formWidth) { angle = Math.PI - angle; X = formWidth; }
            if (Y < 0) { angle = -angle; Y = 0; }
            if (Y > formHeight) { angle = -angle; Y = formHeight; }
        }

        public void Eat(Food food)
        {
            if (Math.Abs(X - food.X) < 5 && Math.Abs(Y - food.Y) < 5)
            {
                Energy += food.NutritionValue;
                HungerLevel = Math.Max(0, HungerLevel - food.NutritionValue);
                food.Dead();
            }
        }
    }
}
