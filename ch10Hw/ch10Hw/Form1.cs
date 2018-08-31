using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10Hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // the showanimalinfo method accepts an animal object and displays the objects
        //species and calls the makesound method

         private void Showanimalinfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
      
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {
            Animal myanimal = new Animal("Wild thing");
            Showanimalinfo(myanimal);
        }

        private void DogButton_Click(object sender, EventArgs e)
        {
            Dog mydog = new Dog("Fido");
            MessageBox.Show("The dog's name is "  + mydog.Name);
            Showanimalinfo(mydog);
        }

        private void CatButton_Click_1(object sender, EventArgs e)
        {
            Cat mycat = new Cat("Whiskers");
            MessageBox.Show("The Cats name is " + mycat.Name);
            Showanimalinfo(mycat);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
