using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10Hw
{
    class Cat : Animal
    {
        private string _name;

       public Cat(string name)
            : base("Cat")
        {
            _name = name;
        }
        // Name property  
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 
      
        // Makesound method
        public override void MakeSound()
        {
            MessageBox.Show("Meowwww");
        }
    }
}
