namespace ch10Hw
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
            this.AnimalButton = new System.Windows.Forms.Button();
            this.DogButton = new System.Windows.Forms.Button();
            this.CatButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalButton
            // 
            this.AnimalButton.Location = new System.Drawing.Point(58, 15);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(75, 35);
            this.AnimalButton.TabIndex = 0;
            this.AnimalButton.Text = "Create an animal";
            this.AnimalButton.UseVisualStyleBackColor = true;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // DogButton
            // 
            this.DogButton.Location = new System.Drawing.Point(248, 15);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(75, 38);
            this.DogButton.TabIndex = 1;
            this.DogButton.Text = "Create a dog";
            this.DogButton.UseVisualStyleBackColor = true;
            this.DogButton.Click += new System.EventHandler(this.DogButton_Click);
            // 
            // CatButton
            // 
            this.CatButton.Location = new System.Drawing.Point(413, 15);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(75, 35);
            this.CatButton.TabIndex = 2;
            this.CatButton.Text = "Create a cat";
            this.CatButton.UseVisualStyleBackColor = true;
            this.CatButton.Click += new System.EventHandler(this.CatButton_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(248, 92);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 157);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CatButton);
            this.Controls.Add(this.DogButton);
            this.Controls.Add(this.AnimalButton);
            this.Name = "Form1";
            this.Text = "Polymorphism";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnimalButton;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

