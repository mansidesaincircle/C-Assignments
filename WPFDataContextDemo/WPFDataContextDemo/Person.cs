using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataContextDemo
{
    public class Person
    {
        private string fname;
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        private string lname;
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
