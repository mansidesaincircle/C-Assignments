using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFBasicMVVMDemo.Command
{
    public class RelayCommand : ICommand
    {
        Action<object> executeMethod;
        Func<object,bool> canExecute;
        bool canExecuteCache;     //for buttonn enabling and disabling button

        public RelayCommand(Action<object> executeMethod, Func<object,bool> canExecute, bool canExecuteCache)
        {
            this.executeMethod = executeMethod;
            this.canExecute = canExecute;
            canExecuteCache = canExecuteCache;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }

        }

        public bool CanExecute(object parameter)
        {
            if(canExecute==null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
