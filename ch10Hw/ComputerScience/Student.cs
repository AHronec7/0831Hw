using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
        abstract class Student
    {
        // fields
        private string _name;
        private string _id;

        // the constructor
        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }
        // Now for the properties, the name property and the id property
        // Name

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Id
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        // required proeprty(abstract)
        public abstract double Hours
        {
            get;
        }
    }
}
