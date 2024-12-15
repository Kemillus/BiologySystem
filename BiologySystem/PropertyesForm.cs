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
    public partial class PropertiesForm : Form
    {
        public Organism Organism { get; set; }
        public Predator Predator { get; set; }
        public Food Food { get; set; }
        public Herbivore Herbivore { get; set; }

        public PropertiesForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(OrganismsEnum));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(maskedSpeed.Text, out int speed) ||
                !int.TryParse(maskedEnergy.Text, out int energy) ||
                !int.TryParse(maskedHungerLevel.Text, out int hungerLevel) ||
                !int.TryParse(maskedVisouRadius.Text, out int visouRadius) ||
                !int.TryParse(maskedNutritionValue.Text, out int nutritionValue))
            {
                MessageBox.Show("ERROR, check values");
                return;
            }

            switch (comboBox1.Text)
            {
                case "Herbivore":
                    
                    Herbivore = new Herbivore(0, 0, speed, Color.Blue, hungerLevel, energy, visouRadius);
                    break;
                case "Predator":
                    
                    Predator = new Predator(0, 0, speed, Color.Red, hungerLevel, energy, visouRadius);
                    break;
                case "Food":
                    Food = new Food(0, 0, 0, 0, 0, 0, Color.Green, nutritionValue);
                    break;
                default:
                    break;
            }
        }

        private bool CheckValues()
        {
            if (!int.TryParse(maskedSpeed.Text, out int speed) ||
                !int.TryParse(maskedEnergy.Text, out int energy) ||
                !int.TryParse(maskedHungerLevel.Text, out int hungerLevel) ||
                !int.TryParse(maskedVisouRadius.Text, out int visouRadius))
            {
                MessageBox.Show("ERROR, check values");
                return false;
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Food")
            {
                maskedEnergy.Enabled = false;
                maskedEnergy.Text = "0";
                maskedHungerLevel.Enabled = false;
                maskedHungerLevel.Text = "0";
                maskedSpeed.Enabled = false;
                maskedSpeed.Text = "0";
                maskedVisouRadius.Enabled = false;
                maskedVisouRadius.Text = "0";
            }
            else
            {
                maskedEnergy.Enabled = true;
                maskedHungerLevel.Enabled = true;
                maskedSpeed.Enabled = true;
                maskedVisouRadius.Enabled = true;
            }
        }
    }
}
