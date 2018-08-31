using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10Hw
{
    class Dog : Animal
    {
        private string _name;

        // constructor
        public Dog(string name)
             : base("Dog")
        {
            _name = name;
        }
        // the name property
        public string Name
        {
            get { return _name; }
            set { _name= value; }
        }
        //MakeSound Method
        public override void MakeSound()
        {
            MessageBox.Show("Woof, Woof");
        }
    }
}
