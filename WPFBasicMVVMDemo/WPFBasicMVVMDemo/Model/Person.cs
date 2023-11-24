using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBasicMVVMDemo.Model
{
    public class Person:INotifyPropertyChanged
    {
        private String fname;
        public string Fname
        {
            get { return fname; }
            set { fname = value; /*OnPropertyChanged(Fname);*/ }
        }

        private String lname;
        public string Lname
        {
            get { return lname; }
            set { lname = value; /*OnPropertyChanged(Lname);*/ }
        }

        private String fullname;

        public string Fullname
        {
            get { return Fname+ " "+lname; }
            set
            {
                if(fullname!=value)
                {
                    fullname = value; OnPropertyChanged(Fullname);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
           
        }
    }
}
