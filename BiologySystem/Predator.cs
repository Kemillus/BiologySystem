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
        public Predator(int x, int y, int speed, Color color, int hungerLevel, int energy, int visionRadius)
            : base(x, y, speed, color, hungerLevel, energy, visionRadius)
        {

        }

        public Herbivore FindNearestPrey(List<Organism> organisms)
        {
            Herbivore nearestPrey = null;
            double minDistance = double.MaxValue;

            foreach (var organism in organisms)
            {
                if (organism is Herbivore prey)
                {
                    double distance = DistanceTo(prey);
                    if (distance < minDistance && distance <= VisionRadius)
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
            Herbivore targetPrey = FindNearestPrey(organisms.FindAll(o => !o.IsDead));
            if (targetPrey != null)
            {
                MoveTowardsTarget(targetPrey);
                if (DistanceTo(targetPrey) < 5)
                {
                    Hunt(targetPrey);
                }
            }
            else
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
        }

        public void Hunt(Herbivore herbivore)
        {
            if (Math.Abs(X - herbivore.X) < 5 && Math.Abs(Y - herbivore.Y) < 5)
            {
                Energy += herbivore.Energy;
                HungerLevel -= herbivore.Energy;
                //herbivore.Dead();
            }
        }
    }

}
