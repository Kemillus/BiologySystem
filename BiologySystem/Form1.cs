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

        public MainForm()
        {
            InitializeComponent();
            organisms = new List<Organism>();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerTick;
            foodSpawnTimer = new Timer();
            foodSpawnTimer.Interval = 5000;
            foodSpawnTimer.Tick += TimerSpawnFood;
            timer.Start();
            foodSpawnTimer.Start();
        }

        private void TimerSpawnFood(object sender, EventArgs e)
        {
            var rand = new Random();
            var food = new Food(rand.Next(ClientSize.Width), rand.Next(ClientSize.Height), 0, Color.Green, 5);
            organisms.Add(food);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var organism in organisms)
            {
                organism.Move(ClientSize.Width, ClientSize.Height);
            }

            for (int i = 0; i < organisms.Count; i++)
            {
                for (int j = i + 1; j < organisms.Count; j++)
                {
                    if (organisms[i] is Herbivore herbivore && organisms[j] is Food food)
                    {
                        herbivore.Eat(food);
                    }
                    else if (organisms[i] is Predator predator && organisms[j] is Herbivore prey)
                    {
                        predator.Hunt(prey);
                    }
                }
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var organism in organisms)
            {
                organism.Draw(e.Graphics);
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            organisms.Add(new Food(100, 100, 0, Color.Green, 10));
            organisms.Add(new Herbivore(200, 200, 5, Color.Blue, 50, 100));
            organisms.Add(new Predator(220, 220, 12, Color.Red, 30, 100, 2));
        }
    }
}
