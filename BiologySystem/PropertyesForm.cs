using System;
using System.Drawing;
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
                !int.TryParse(maskedVisonRadius.Text, out int visouRadius) ||
                !int.TryParse(maskedNutritionValue.Text, out int nutritionValue) ||
                !int.TryParse(maskedMaxHunger.Text, out int maxHunger) ||
                !int.TryParse(maskedReprodyce.Text, out int energyReprodyce) ||
                !int.TryParse(maskedLifeSpan.Text, out int lifeSpan))
            {
                MessageBox.Show("ERROR, check values");
                return;
            }

            switch (comboBox1.Text)
            {
                case "Herbivore":

                    Herbivore = new Herbivore(0, 0, speed, hungerLevel, maxHunger, energy,
                        energyReprodyce, nutritionValue, visouRadius, lifeSpan, Color.Blue);
                    break;
                case "Predator":

                    Predator = new Predator(0, 0, speed, hungerLevel, maxHunger, energy,
                        energyReprodyce, visouRadius, lifeSpan, Color.Red);
                    break;
                case "Food":
                    Food = new Food(0, 0, 0, 0, 0, 0, 0, 0, Color.Green, lifeSpan, nutritionValue);
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == OrganismsEnum.Food.ToString())
            {
                maskedNutritionValue.Enabled = true;
                maskedEnergy.Enabled = false;
                maskedEnergy.Text = "0";
                maskedHungerLevel.Enabled = false;
                maskedHungerLevel.Text = "0";
                maskedSpeed.Enabled = false;
                maskedSpeed.Text = "0";
                maskedVisonRadius.Enabled = false;
                maskedVisonRadius.Text = "0";
                maskedReprodyce.Enabled = false;
                maskedReprodyce.Text = "0";
                maskedMaxHunger.Enabled = false;
                maskedMaxHunger.Text = "0";
            }

            else if (comboBox1.Text == OrganismsEnum.Predator.ToString())
            {
                maskedEnergy.Enabled = true;
                maskedHungerLevel.Enabled = true;
                maskedSpeed.Enabled = true;
                maskedNutritionValue.Enabled = false;
                maskedNutritionValue.Text = "0";
                maskedSpeed.Enabled = true;
                maskedVisonRadius.Enabled = true;
            }

            else
            {
                maskedEnergy.Enabled = true;
                maskedHungerLevel.Enabled = true;
                maskedMaxHunger.Enabled = true;
                maskedSpeed.Enabled = true;
                maskedVisonRadius.Enabled = true;
                maskedNutritionValue.Enabled = true;
                maskedReprodyce.Enabled = true;
                maskedLifeSpan.Enabled = true;
            }
        }
    }
}
