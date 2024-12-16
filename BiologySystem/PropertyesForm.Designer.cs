namespace BiologySystem
{
    partial class PropertiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreate = new System.Windows.Forms.Button();
            this.maskedHungerLevel = new System.Windows.Forms.MaskedTextBox();
            this.maskedEnergy = new System.Windows.Forms.MaskedTextBox();
            this.maskedVisonRadius = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedSpeed = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedNutritionValue = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedMaxHunger = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedReprodyce = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedLifeSpan = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Location = new System.Drawing.Point(168, 415);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "OK";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // maskedHungerLevel
            // 
            this.maskedHungerLevel.Location = new System.Drawing.Point(16, 143);
            this.maskedHungerLevel.Mask = "00000";
            this.maskedHungerLevel.Name = "maskedHungerLevel";
            this.maskedHungerLevel.Size = new System.Drawing.Size(100, 20);
            this.maskedHungerLevel.TabIndex = 1;
            this.maskedHungerLevel.ValidatingType = typeof(int);
            // 
            // maskedEnergy
            // 
            this.maskedEnergy.Location = new System.Drawing.Point(158, 143);
            this.maskedEnergy.Mask = "00000";
            this.maskedEnergy.Name = "maskedEnergy";
            this.maskedEnergy.Size = new System.Drawing.Size(100, 20);
            this.maskedEnergy.TabIndex = 4;
            this.maskedEnergy.ValidatingType = typeof(int);
            // 
            // maskedVisonRadius
            // 
            this.maskedVisonRadius.Location = new System.Drawing.Point(300, 143);
            this.maskedVisonRadius.Mask = "00000";
            this.maskedVisonRadius.Name = "maskedVisonRadius";
            this.maskedVisonRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedVisonRadius.TabIndex = 6;
            this.maskedVisonRadius.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hunger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Energy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vision Radius";
            // 
            // maskedSpeed
            // 
            this.maskedSpeed.Location = new System.Drawing.Point(300, 195);
            this.maskedSpeed.Mask = "00000";
            this.maskedSpeed.Name = "maskedSpeed";
            this.maskedSpeed.Size = new System.Drawing.Size(100, 20);
            this.maskedSpeed.TabIndex = 7;
            this.maskedSpeed.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(147, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maskedNutritionValue
            // 
            this.maskedNutritionValue.Location = new System.Drawing.Point(300, 247);
            this.maskedNutritionValue.Mask = "00000";
            this.maskedNutritionValue.Name = "maskedNutritionValue";
            this.maskedNutritionValue.Size = new System.Drawing.Size(100, 20);
            this.maskedNutritionValue.TabIndex = 8;
            this.maskedNutritionValue.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nutrition Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // maskedMaxHunger
            // 
            this.maskedMaxHunger.Location = new System.Drawing.Point(16, 195);
            this.maskedMaxHunger.Mask = "00000";
            this.maskedMaxHunger.Name = "maskedMaxHunger";
            this.maskedMaxHunger.Size = new System.Drawing.Size(100, 20);
            this.maskedMaxHunger.TabIndex = 2;
            this.maskedMaxHunger.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max Hunger";
            // 
            // maskedReprodyce
            // 
            this.maskedReprodyce.Location = new System.Drawing.Point(158, 195);
            this.maskedReprodyce.Mask = "00000";
            this.maskedReprodyce.Name = "maskedReprodyce";
            this.maskedReprodyce.Size = new System.Drawing.Size(100, 20);
            this.maskedReprodyce.TabIndex = 5;
            this.maskedReprodyce.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Energy For Reprodyce";
            // 
            // maskedLifeSpan
            // 
            this.maskedLifeSpan.Location = new System.Drawing.Point(16, 247);
            this.maskedLifeSpan.Mask = "000000";
            this.maskedLifeSpan.Name = "maskedLifeSpan";
            this.maskedLifeSpan.Size = new System.Drawing.Size(100, 20);
            this.maskedLifeSpan.TabIndex = 3;
            this.maskedLifeSpan.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Life Span";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedVisonRadius);
            this.Controls.Add(this.maskedReprodyce);
            this.Controls.Add(this.maskedEnergy);
            this.Controls.Add(this.maskedSpeed);
            this.Controls.Add(this.maskedNutritionValue);
            this.Controls.Add(this.maskedLifeSpan);
            this.Controls.Add(this.maskedMaxHunger);
            this.Controls.Add(this.maskedHungerLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreate);
            this.Name = "PropertiesForm";
            this.Text = "Propertyes Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.MaskedTextBox maskedHungerLevel;
        private System.Windows.Forms.MaskedTextBox maskedEnergy;
        private System.Windows.Forms.MaskedTextBox maskedVisonRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedNutritionValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedMaxHunger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedReprodyce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedLifeSpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}