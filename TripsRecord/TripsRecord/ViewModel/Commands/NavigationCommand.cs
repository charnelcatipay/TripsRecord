using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TripsRecord.ViewModel.Commands
{
    public class NavigationCommand : ICommand
    {
        public HomeVM HomeViewModel { get; set; }

        public NavigationCommand(HomeVM homeVM)
        {
            HomeViewModel = homeVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
