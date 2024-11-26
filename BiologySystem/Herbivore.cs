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
            Food targetFood = FindNearestFood(organisms.FindAll(o => !o.IsDead));

            if (targetFood != null)
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
    }
}
