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
            this.maskedVisouRadius = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedSpeed = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedNutritionValue = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Location = new System.Drawing.Point(168, 415);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
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
            this.maskedEnergy.TabIndex = 1;
            this.maskedEnergy.ValidatingType = typeof(int);
            // 
            // maskedVisouRadius
            // 
            this.maskedVisouRadius.Location = new System.Drawing.Point(300, 143);
            this.maskedVisouRadius.Mask = "00000";
            this.maskedVisouRadius.Name = "maskedVisouRadius";
            this.maskedVisouRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedVisouRadius.TabIndex = 1;
            this.maskedVisouRadius.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Huger";
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
            this.maskedSpeed.Location = new System.Drawing.Point(158, 195);
            this.maskedSpeed.Mask = "00000";
            this.maskedSpeed.Name = "maskedSpeed";
            this.maskedSpeed.Size = new System.Drawing.Size(100, 20);
            this.maskedSpeed.TabIndex = 1;
            this.maskedSpeed.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maskedNutritionValue
            // 
            this.maskedNutritionValue.Location = new System.Drawing.Point(16, 195);
            this.maskedNutritionValue.Mask = "00000";
            this.maskedNutritionValue.Name = "maskedNutritionValue";
            this.maskedNutritionValue.Size = new System.Drawing.Size(100, 20);
            this.maskedNutritionValue.TabIndex = 1;
            this.maskedNutritionValue.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nutrition Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedVisouRadius);
            this.Controls.Add(this.maskedEnergy);
            this.Controls.Add(this.maskedSpeed);
            this.Controls.Add(this.maskedNutritionValue);
            this.Controls.Add(this.maskedHungerLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreate);
            this.Name = "PropertiesForm";
            this.Text = "PropertyesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.MaskedTextBox maskedHungerLevel;
        private System.Windows.Forms.MaskedTextBox maskedEnergy;
        private System.Windows.Forms.MaskedTextBox maskedVisouRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedSpeed;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedNutritionValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}