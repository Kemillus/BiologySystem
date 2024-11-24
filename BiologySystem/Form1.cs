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
        public MainForm()
        {
            InitializeComponent();
            organisms = new List<Organism>();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var organism in organisms)
            {
                organism.Move();
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
            organisms.Add(new Predator(300, 300, 7, Color.Red, 30, 100, 2));
        }
    }
}
