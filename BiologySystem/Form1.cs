﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

        private Predator predator;
        private Herbivore herbivore;
        private Food food;

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
            if (organisms.Count == 0)
            {
                labelMessage.ForeColor = Color.LightSlateGray;
                labelMessage.Text = "Create organisms";
                return;
            }

            labelMessage.Text = "";
            rand = new Random(Guid.NewGuid().GetHashCode());
            int x = rand.Next(ClientSize.Width);
            int y = rand.Next(ClientSize.Height);
            organisms.Add(new Food(x, y, 0, 0, 0, 0, 0, 0, food.Color, food.LifeSpan, food.NutritionValue));
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var organism in organisms.FindAll(o => !o.IsDead))
            {
                organism.Move(ClientSize.Width, ClientSize.Height, organisms);
                organism.Reproduce(organisms, ClientSize.Width, ClientSize.Height);
            }

            organisms.RemoveAll(o => o.IsDead && o.TimerRec <= 0);
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

                    properties = organism.ToString();
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
                        if (predator == null)
                        {
                            MessageBox.Show("Predator don't Create");
                            return;
                        }
                        organisms.Add(new Predator(posX, posY, predator.Speed, predator.HungerLevel, predator.MaxHungerLevel,
                            predator.Energy, predator.EnergyForReproduction, predator.VisionRadius, predator.LifeSpan, predator.Color));
                        break;
                    case "buttonHerbivore":
                        if (herbivore == null)
                        {
                            MessageBox.Show("Herbivore don't Create");
                            return;
                        }
                        organisms.Add(new Herbivore(posX, posY, herbivore.Speed, herbivore.HungerLevel, herbivore.MaxHungerLevel,
                            herbivore.Energy, herbivore.EnergyForReproduction, herbivore.NutritionValue, herbivore.VisionRadius,
                            herbivore.LifeSpan, herbivore.Color));
                        break;
                    case "buttonFood":
                        if (food == null)
                        {
                            MessageBox.Show("Food don't Create");
                            return;
                        }
                        organisms.Add(new Food(posX, posY, 0, 0, 0, 0, 0, 0, food.Color,food.LifeSpan, food.NutritionValue));
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

        private void button1_Click(object sender, EventArgs e)
        {
            PropertiesForm form = new PropertiesForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (form.Herbivore != null)
                {
                    herbivore = form.Herbivore;
                }
                if (form.Predator != null)
                {
                    predator = form.Predator;
                }
                if (form.Food != null)
                {
                    food = form.Food;
                }
            }
        }
    }
}
