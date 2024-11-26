namespace BiologySystem
{
    partial class MainForm
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
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.buttonPredator = new System.Windows.Forms.Button();
            this.buttonHerbivore = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.Location = new System.Drawing.Point(713, 12);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneral.TabIndex = 0;
            this.buttonGeneral.Text = "General";
            this.buttonGeneral.UseVisualStyleBackColor = true;
            this.buttonGeneral.Click += new System.EventHandler(this.MainFormLoad);
            // 
            // buttonPredator
            // 
            this.buttonPredator.Location = new System.Drawing.Point(713, 50);
            this.buttonPredator.Name = "buttonPredator";
            this.buttonPredator.Size = new System.Drawing.Size(75, 23);
            this.buttonPredator.TabIndex = 0;
            this.buttonPredator.Text = "Predator";
            this.buttonPredator.UseVisualStyleBackColor = true;
            this.buttonPredator.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // buttonHerbivore
            // 
            this.buttonHerbivore.Location = new System.Drawing.Point(713, 88);
            this.buttonHerbivore.Name = "buttonHerbivore";
            this.buttonHerbivore.Size = new System.Drawing.Size(75, 23);
            this.buttonHerbivore.TabIndex = 0;
            this.buttonHerbivore.Text = "Herbivore";
            this.buttonHerbivore.UseVisualStyleBackColor = true;
            this.buttonHerbivore.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(713, 126);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(75, 23);
            this.buttonFood.TabIndex = 0;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonHerbivore);
            this.Controls.Add(this.buttonPredator);
            this.Controls.Add(this.buttonGeneral);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeneral;
        private System.Windows.Forms.Button buttonPredator;
        private System.Windows.Forms.Button buttonHerbivore;
        private System.Windows.Forms.Button buttonFood;
    }
}

