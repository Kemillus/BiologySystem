using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    public class Herbivore : Organism
    {
        private Food targetFood = null;
        public int NutritionValue { get; set; }

        public Herbivore(int x, int y, int speed,
            int hungerLevel, int maxHunger, int energy, int energyReprodyce, int nutritionValue, int visionRadius, Color color)
            : base(x, y, speed, hungerLevel, maxHunger, energy, energyReprodyce, visionRadius, color)
        {
            NutritionValue = nutritionValue;
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

            if (HungerLevel >= 700)
            {
                Dead();
                return;
            }

            if (HungerLevel >= 400)
            {
                Speed = startSpeed * 2;
                if (targetFood == null || !targetFood.IsDead)
                {
                    targetFood = FindNearestFood(organisms);
                }
            }
            else if (HungerLevel >= 200)
            {
                Speed = startSpeed + startSpeed / 2;
                if (targetFood == null || !targetFood.IsDead)
                {
                    targetFood = FindNearestFood(organisms);
                }
            }
            else
            {
                Speed = startSpeed;
                targetFood = null;
                MoveRandom(formWidth, formHeight);
            }

            if (targetFood != null && !targetFood.IsDead)
            {
                MoveTowardsTarget(targetFood);
                if (DistanceTo(targetFood) < 3)
                {
                    Eat(targetFood);
                    targetFood = null;
                }
            }

            else
            {
                targetFood = null;
                MoveRandom(formWidth, formHeight);
            }
        }

        public void Eat(Food food)
        {
            Energy += food.NutritionValue;
            HungerLevel = Math.Max(0, HungerLevel - food.NutritionValue);
            Speed = startSpeed;
            food.Dead();
        }

        public override void Reproduce(List<Organism> organisms, int formWidth, int formHeight)
        {
            int reproductionCost = 20;

            if (Energy > reproductionCost)
            {
                Energy -= reproductionCost;

                Random rand = new Random();
                int xOffxet = rand.Next(-10, 11);
                int yOffset = rand.Next(-10, 11);
                int newX = X + xOffxet;
                int newY = Y + yOffset;

                if (newX < 0) newX = 0;
                if (newX > formWidth) newX = formWidth;
                if (newY < 0) newY = 0;
                if (newY > formHeight) newY = formHeight;
                organisms.Add(new Herbivore(newX, newY, Speed, 0, MaxHungerLevel, 0, EnergyForReproduction,
                    NutritionValue, VisionRadius, Color));
            }
        }
    }
}
