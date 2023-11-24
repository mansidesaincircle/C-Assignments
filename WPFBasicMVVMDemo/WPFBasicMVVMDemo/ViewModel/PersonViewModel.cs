using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFBasicMVVMDemo.Command;
using WPFBasicMVVMDemo.Model;

namespace WPFBasicMVVMDemo.ViewModel
{
    //why here we use INotifyPropertyChanged bcoz we want data change from ui to viewmodel and viewmodel to ui
    public class PersonViewModel : INotifyPropertyChanged
    {
        //Property which will contain the fields
        private Person _person;
        public Person Person
        {
            get {return _person; }
            set { _person = value; NotifyPropertyChanged("Person"); }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person>Persons
        {
            get { return _persons; }
            set { _persons = value; NotifyPropertyChanged("Persons"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        //lines declares a private field of Icommand to store the command instance
        private ICommand _SubmitCommand;

        public ICommand SubmitCommand
        {
            get
            {
                if(_SubmitCommand==null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _SubmitCommand;
            }
        }

        public PersonViewModel()
        {
            // Initialize Person here 
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }
        private void SubmitExecute(Object parameter)
        {
            Persons.Add(Person);
        }

        private bool CanSubmitExecute(Object parameter)
        {
            if(string.IsNullOrEmpty(Person.Fname) || string.IsNullOrEmpty(Person.Lname))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        


        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }



    }
}
