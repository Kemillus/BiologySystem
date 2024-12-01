using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologySystem
{
    internal class Predator : Organism
    {
        public int HungerLevel { get; set; }
        public int Energy { get; set; }
        public int VisionRadius { get; set; }
        private Herbivore targetPrey = null;

        public Predator(int x, int y, int speed, Color color, int hungerLevel, int energy, int visionRadius)
            : base(x, y, speed, color)
        {
            HungerLevel = hungerLevel;
            Energy = energy;
            VisionRadius = visionRadius;
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

            targetPrey = null;
            if (targetPrey == null || targetPrey.IsDead)
            {
                targetPrey = FindNearestPrey(organisms);
            }

            if (targetPrey != null && !targetPrey.IsDead)
            {
                MoveTowardsTarget(targetPrey);
                if (DistanceTo(targetPrey) < 5)
                {
                    Hunt(targetPrey);
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
            if (Math.Abs(X - herbivore.X) < 5 && Math.Abs(Y - herbivore.Y) < 5)
            {
                Energy += herbivore.Energy;
                HungerLevel -= herbivore.Energy;
                herbivore.Dead();
            }
        }

        public override void Reproduce(List<Organism> organisms, int formWidth, int formHeight)
        {
            int reproductionCost = 50;

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
                if(newY > formHeight) newY = formHeight;
                organisms.Add(new Predator(newX, newY, Speed, Color, 0, Energy / 2, VisionRadius));
            }
        }
    }
}
