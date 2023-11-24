using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    public class Command : ICommand
    {

        // Represents an action to be executed when the command is triggered.
        Action<object> executeMethod;

        // Represents a function that determines whether the command can be executed.
     //   Func<object, bool> canexecuteMethod;


        //constructor intialize the variable
        public Command(Action<object> executeMethod)
        {
            this.executeMethod = executeMethod;
            //this.canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
