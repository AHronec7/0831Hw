using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10Hw
{
    class Animal
    {
        // field 
        private string _species;

        //constructor

        public Animal(string species)
        {
            _species = species;
        }
        // the species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }
    
        

        // method
        //the virtual keyword allows for the method to be overidden from the base class
        public virtual void MakeSound()
        {
            MessageBox.Show("GRRRRR");
        }
    }
}
