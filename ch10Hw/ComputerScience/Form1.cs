using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // variables to hold the input
            string name, id, track;

            // get the student name and id 
            name = NameTextBox.Text;
            id = IdTextBox.Text;

            // get the students academic track
            if (InformationRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Sofware Engineering";
            }
            //create a computerscience student object(new keyword)
            ComputerScienceStudent css = new ComputerScienceStudent(name, id, track);

            //display the required hours
            HoursLabel.Text = css.Hours.ToString();

            
        }
    }
}
