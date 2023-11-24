using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    public class ViewModel
    {
        public ICommand MyCommand { get; set; }
        public ViewModel()
        {
            MyCommand = new Command(Execute);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Command Executed...");
        }
    }
}
