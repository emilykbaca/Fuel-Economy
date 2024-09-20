namespace Fuel_Economy
{
    partial class fuelEconomyForm
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
            this.milesDrivenLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesDrivenLabel
            // 
            this.milesDrivenLabel.AutoSize = true;
            this.milesDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.milesDrivenLabel.Location = new System.Drawing.Point(43, 36);
            this.milesDrivenLabel.Name = "milesDrivenLabel";
            this.milesDrivenLabel.Size = new System.Drawing.Size(365, 29);
            this.milesDrivenLabel.TabIndex = 0;
            this.milesDrivenLabel.Text = "Enter the number of miles driven:";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gallonsLabel.Location = new System.Drawing.Point(79, 94);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(329, 29);
            this.gallonsLabel.TabIndex = 1;
            this.gallonsLabel.Text = "Enter the gallons of gas used:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(223, 152);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(185, 29);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Your car\'s MPG:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(444, 36);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(259, 26);
            this.milesTextBox.TabIndex = 3;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(444, 94);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(259, 26);
            this.gallonsTextBox.TabIndex = 4;
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(444, 152);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(259, 36);
            this.mpgLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateButton.Location = new System.Drawing.Point(169, 230);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(152, 75);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(393, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 75);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fuelEconomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 331);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.milesDrivenLabel);
            this.Name = "fuelEconomyForm";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesDrivenLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

