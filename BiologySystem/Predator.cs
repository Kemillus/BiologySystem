using System;
using System.Collections.Generic;
using System.Drawing;

namespace BiologySystem
{
    public class Predator : Organism
    {
        private Herbivore targetPrey = null;

        public Predator(int x, int y, int speed, int hungerLevel, int maxHunger, int energy,
            int energyReprodyce, int visionRadius, int lifeSpan, Color color)
            : base(x, y, speed, hungerLevel, maxHunger, energy, energyReprodyce, visionRadius, lifeSpan, color)
        {

        }

        public Herbivore FindNearestPrey(List<Organism> organisms)
        {
            Herbivore nearestPrey = null;
            double minDistance = double.MaxValue;

            foreach (var organism in organisms)
            {
                if (organism is Herbivore prey && !prey.IsDead)
                {
                    double distance = DistanceTo(prey);
                    if (distance <= VisionRadius && distance < minDistance)
                    {
                        minDistance = distance;
                        nearestPrey = prey;
                    }
                }
            }

            return nearestPrey;
        }

        public override void Move(int formWidth, int formHeight, List<Organism> organisms)
        {
            HungerLevel += HungerIncrease;
            LifeTime += 1;

            if (HungerLevel >= MaxHungerLevel || LifeTime >= LifeSpan)
            {
                Dead();
                return;
            }

            if (HungerLevel >= MaxHungerLevel / 2)
            {
                Speed = startSpeed * 2;
                if (targetPrey == null || !targetPrey.IsDead)
                {
                    targetPrey = FindNearestPrey(organisms);
                }
            }

            else if (HungerLevel >= MaxHungerLevel / 3)
            {
                Speed = startSpeed + startSpeed / 2;

                if (targetPrey == null || targetPrey.IsDead)
                {
                    targetPrey = FindNearestPrey(organisms);
                }
            }

            else
            {
                Speed = startSpeed;
                targetPrey = null;
                MoveRandom(formWidth, formHeight);
            }

            if (targetPrey != null && !targetPrey.IsDead)
            {
                MoveTowardsTarget(targetPrey);
                if (DistanceTo(targetPrey) < 5)
                {
                    Hunt(targetPrey);
                    targetPrey = null;
                }
            }

            else
            {
                targetPrey = null;
                MoveRandom(formWidth, formHeight);
            }
        }

        private void MoveTowardsTarget(Organism target)
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

        public void Hunt(Herbivore herbivore)
        {
            Energy += herbivore.NutritionValue;
            HungerLevel -= herbivore.NutritionValue;
            Speed = startSpeed;
            herbivore.Dead();
        }

        public override void Reproduce(List<Organism> organisms, int formWidth, int formHeight)
        {
            if (Energy > EnergyForReproduction)
            {
                Energy -= EnergyForReproduction;

                Random rand = new Random();
                int xOffxet = rand.Next(-10, 11);
                int yOffset = rand.Next(-10, 11);
                int newX = X + xOffxet;
                int newY = Y + yOffset;

                if (newX < 0) newX = 0;
                if (newX > formWidth) newX = formWidth;
                if (newY < 0) newY = 0;
                if (newY > formHeight) newY = formHeight;
                organisms.Add(new Predator(newX, newY, Speed, 0, MaxHungerLevel, 0, EnergyForReproduction,
                    VisionRadius, LifeSpan, Color));
            }
        }

        public override string ToString()
        {
            return $"S{Speed}, H{HungerLevel}, E{Energy}, LT{LifeTime}";
        }
    }
}
