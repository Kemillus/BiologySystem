using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiologySystem
{
    public partial class MainForm : Form
    {
        private List<Organism> organisms;
        private Timer timer;
        private Timer foodSpawnTimer;
        private Random rand;
        private bool isPaused = false;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            organisms = new List<Organism>();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerTick;
            timer.Start();

            foodSpawnTimer = new Timer();
            foodSpawnTimer.Interval = 5000;
            foodSpawnTimer.Tick += FoodSpawnTimerTick;
            foodSpawnTimer.Start();
        }

        private void FoodSpawnTimerTick(object sender, EventArgs e)
        {
            rand = new Random(Guid.NewGuid().GetHashCode());
            int x = rand.Next(ClientSize.Width);
            int y = rand.Next(ClientSize.Height);
            organisms.Add(new Food(x, y, 0, Color.Green, 10));
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var organism in organisms.FindAll(o => !o.IsDead))
            {
                organism.Move(ClientSize.Width, ClientSize.Height, organisms);
                organism.Reproduce(organisms, ClientSize.Width, ClientSize.Height);
            }

            //organisms.RemoveAll(o => o.IsDead);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var organism in organisms)
            {
                organism.Draw(e.Graphics);

                if (isPaused && !organism.IsDead)
                {
                    string properties = "";

                    if (organism is Herbivore herbivore)
                    {
                        properties = $"Speed: {herbivore.Speed}, Hunger: {herbivore.HungerLevel}, Energy: {herbivore.Energy}";
                    }
                    else if (organism is Predator predator)
                    {
                        properties = $"Speed: {predator.Speed}, Hunger: {predator.HungerLevel}, Energy: {predator.Energy}";
                    }
                    else if (organism is Food food)
                    {
                        properties = $"Nutrition: {food.NutritionValue}";
                    }


                    Font font = new Font("Arial", 8);
                    SizeF textSize = e.Graphics.MeasureString(properties, font);
                    e.Graphics.DrawString(properties, font, Brushes.Black, organism.X, organism.Y - textSize.Height - 2);
                }
            }
        }

        private void CreateOrganism(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Random rand = new Random();

            int posX = rand.Next(ClientSize.Width);
            int posY = rand.Next(ClientSize.Height);

            if (clickedButton != null)
            {
                switch (clickedButton.Name)
                {
                    case "buttonPredator":
                        organisms.Add(new Predator(posX, posY, 9, Color.Red, 50, 100, 100));
                        break;
                    case "buttonHerbivore":
                        organisms.Add(new Herbivore(posX, posY, 5, Color.Blue, 50, 100, 100));
                        break;
                    case "buttonFood":
                        organisms.Add(new Food(posX, posY, 20, Color.Green, 10));
                        break;
                    default:

                        break;
                }
            }
        }

        private void Paused(object sender, EventArgs e)
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                timer.Stop();
                foodSpawnTimer.Stop();
            }

            else
            {
                timer.Start();
                foodSpawnTimer.Start();
            }

            Invalidate();
        }
    }
}
