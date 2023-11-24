using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFINotifyPropertyChangedDemo
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String property)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        private string fname;
        public string Fname
        {
            get { return fname; }
            set { fname = value; OnPropertyChanged("fname");
                OnPropertyChanged("fullname");
            }
           
        }

        private string lname;
        public string Lname
        {
            get { return lname; }
            set { lname = value; OnPropertyChanged("lname");
                OnPropertyChanged("fullname");
            }
            
        }

        private string fullname;
        public string FullName
        {
            get { return fname+" "+lname; }
            set { fullname = value; }

        }
    }
}
