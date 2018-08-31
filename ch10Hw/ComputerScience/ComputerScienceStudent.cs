using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    class ComputerScienceStudent : Student
    {
        // constants to hold the values 
        private double Math_hrs = 20;
        private double Cs_hrs = 40;
        private double Gen_hrs = 60;

        // field variable
        private string _academic;

        //constuctor
        public ComputerScienceStudent(string name, string id, string track)
                                     :base(name, id)
        {
            _academic = track;
        }
        //academic property
        public string Academic
        {
            get { return _academic; }
            set { _academic = value; }
        }
        // required hrs overide
        public override double Hours 
        {
            get { return Math_hrs + Cs_hrs + Gen_hrs; }
        }
    }
}
