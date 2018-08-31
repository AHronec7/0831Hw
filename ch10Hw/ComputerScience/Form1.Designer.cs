namespace ComputerScience
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.InformationRadioButton = new System.Windows.Forms.RadioButton();
            this.SoftwareRadioButton = new System.Windows.Forms.RadioButton();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Academic Track";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Required hours:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(196, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(196, 121);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(145, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // InformationRadioButton
            // 
            this.InformationRadioButton.AutoSize = true;
            this.InformationRadioButton.Location = new System.Drawing.Point(225, 185);
            this.InformationRadioButton.Name = "InformationRadioButton";
            this.InformationRadioButton.Size = new System.Drawing.Size(119, 17);
            this.InformationRadioButton.TabIndex = 7;
            this.InformationRadioButton.TabStop = true;
            this.InformationRadioButton.Text = "Information Systems";
            this.InformationRadioButton.UseVisualStyleBackColor = true;
            // 
            // SoftwareRadioButton
            // 
            this.SoftwareRadioButton.AutoSize = true;
            this.SoftwareRadioButton.Location = new System.Drawing.Point(225, 222);
            this.SoftwareRadioButton.Name = "SoftwareRadioButton";
            this.SoftwareRadioButton.Size = new System.Drawing.Size(129, 17);
            this.SoftwareRadioButton.TabIndex = 8;
            this.SoftwareRadioButton.TabStop = true;
            this.SoftwareRadioButton.Text = "Software Engineering ";
            this.SoftwareRadioButton.UseVisualStyleBackColor = true;
            // 
            // HoursLabel
            // 
            this.HoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoursLabel.Location = new System.Drawing.Point(218, 276);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(123, 23);
            this.HoursLabel.TabIndex = 9;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(71, 323);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 49);
            this.Button.TabIndex = 10;
            this.Button.Text = "Get Required hours";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(241, 336);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 381);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.SoftwareRadioButton);
            this.Controls.Add(this.InformationRadioButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.RadioButton InformationRadioButton;
        private System.Windows.Forms.RadioButton SoftwareRadioButton;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button Exit;
    }
}

