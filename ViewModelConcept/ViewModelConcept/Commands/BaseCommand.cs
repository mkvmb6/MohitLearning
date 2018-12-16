using System;
using System.Windows.Input;

namespace ViewModelConcept.Commands
{
    public class BaseCommand : ICommand
    {
        private readonly Action myAction;

        public BaseCommand(Action action)
        {
            myAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            myAction();
        }

        public event EventHandler CanExecuteChanged;
    }
}
