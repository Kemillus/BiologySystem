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
            Herbivore targetPrey = FindNearestPrey(organisms);

            if (targetPrey != null)
            {
                MoveTowardsTarget(targetPrey);
                Hunt(targetPrey);
            }
            else
            {
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
            if (Math.Abs(X - herbivore.X) < 5 && Math.Abs(Y - herbivore.Y) < 5)
            {
                Energy += herbivore.Energy;
                HungerLevel -= herbivore.Energy;
                herbivore.Dead();
            }
        }
    }
}
