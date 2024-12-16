using System;
using System.Collections.Generic;
using System.Drawing;

namespace BiologySystem
{
    public class Organism
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
        public int HungerLevel { get; set; }
        public int Energy { get; set; }
        public int VisionRadius { get; set; }
        public int MaxHungerLevel { get; set; }
        public int EnergyForReproduction { get; set; }
        public bool IsDead { get; set; }
        public int HungerIncrease { get; set; }
        public int TimerRec { get; set; }
        public int LifeSpan { get; set; }
        public int LifeTime { get; set; }

        protected int alpha = 255;
        protected double angle = 0;
        protected int startSpeed;
        protected Enum formOrganism;
        protected Random rand = new Random(Guid.NewGuid().GetHashCode());

        public Organism(int x, int y, int speed, int hungerLevel, int maxHunger,
            int energy, int energyReprodyce, int visionRadius, int lifeSpan, Color color)
        {
            X = x;
            Y = y;
            Speed = speed;
            Color = color;
            HungerLevel = hungerLevel;
            Energy = energy;
            VisionRadius = visionRadius;
            MaxHungerLevel = maxHunger;
            EnergyForReproduction = energyReprodyce;
            LifeSpan = lifeSpan;
            startSpeed = speed;
            LifeTime = 0;
            rand = new Random(Guid.NewGuid().GetHashCode());
            HungerIncrease = 1;
            TimerRec = 250;
            formOrganism = FormOrganism.Rect;
        }

        public virtual void Dead()
        {
            IsDead = true;
        }

        public double DistanceTo(Organism other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }

        public virtual void Move(int formWidth, int formHeight, List<Organism> organisms)
        {

        }

        protected void MoveRandom(int formWidth, int formHeight)
        {
            if (rand.NextDouble() < 0.05)
            {
                angle = rand.NextDouble() * 2 * Math.PI;

                int speedVariation = rand.Next(-2, 3);
                Speed += speedVariation;


                if (Speed < 1) Speed = 1;
                if (Speed > Speed * 2) Speed = startSpeed * 2;
            }

            double dx = Math.Cos(angle) * Speed;
            double dy = Math.Sin(angle) * Speed;

            X += (int)dx;
            Y += (int)dy;

            if (X < 0)
            {
                angle = Math.PI - angle;
                X = 0;
            }
            if (X > formWidth)
            {
                angle = Math.PI - angle;
                X = formWidth;
            }
            if (Y < 0) { angle = -angle; Y = 0; }
            if (Y > formHeight) { angle = -angle; Y = formHeight; }
        }

        public virtual void Draw(Graphics g)
        {
            if (IsDead)
            {
                TimerRec -= 1;
                var color = Color.FromArgb(50, Color);
                var brush = new SolidBrush(color);
                g.FillEllipse(brush, X, Y, 10, 10);
            }

            else
            {
                LifeTime += 1;
                var color = Color.FromArgb(alpha, Color);
                var brush = new SolidBrush(color);
                g.FillEllipse(brush, X, Y, 10, 10);
            }
        }

        public virtual void Reproduce(List<Organism> organisms, int formWidth, int formHeight) { }
    }
}
