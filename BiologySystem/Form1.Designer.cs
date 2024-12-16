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
            this.buttonPredator = new System.Windows.Forms.Button();
            this.buttonHerbivore = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonPaused = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPredator
            // 
            this.buttonPredator.Location = new System.Drawing.Point(713, 12);
            this.buttonPredator.Name = "buttonPredator";
            this.buttonPredator.Size = new System.Drawing.Size(75, 23);
            this.buttonPredator.TabIndex = 0;
            this.buttonPredator.Text = "Predator";
            this.buttonPredator.UseVisualStyleBackColor = true;
            this.buttonPredator.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // buttonHerbivore
            // 
            this.buttonHerbivore.Location = new System.Drawing.Point(713, 50);
            this.buttonHerbivore.Name = "buttonHerbivore";
            this.buttonHerbivore.Size = new System.Drawing.Size(75, 23);
            this.buttonHerbivore.TabIndex = 1;
            this.buttonHerbivore.Text = "Herbivore";
            this.buttonHerbivore.UseVisualStyleBackColor = true;
            this.buttonHerbivore.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(713, 91);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(75, 23);
            this.buttonFood.TabIndex = 2;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.CreateOrganism);
            // 
            // buttonPaused
            // 
            this.buttonPaused.Location = new System.Drawing.Point(713, 130);
            this.buttonPaused.Name = "buttonPaused";
            this.buttonPaused.Size = new System.Drawing.Size(75, 23);
            this.buttonPaused.TabIndex = 3;
            this.buttonPaused.Text = "Pause";
            this.buttonPaused.UseVisualStyleBackColor = true;
            this.buttonPaused.Click += new System.EventHandler(this.Paused);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Properties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPaused);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonHerbivore);
            this.Controls.Add(this.buttonPredator);
            this.Name = "MainForm";
            this.Text = "Biology System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPredator;
        private System.Windows.Forms.Button buttonHerbivore;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonPaused;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMessage;
    }
}

