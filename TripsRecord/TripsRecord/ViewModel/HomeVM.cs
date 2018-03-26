using System;
using System.Collections.Generic;
using System.Text;
using TripsRecord.ViewModel.Commands;

namespace TripsRecord.ViewModel
{
    public class HomeVM
    {
        public NavigationCommand NavCommand;

        public HomeVM()
        {
            NavCommand = new NavigationCommand(this);
        }

        public void Navigate()
        {
            //Todo
        }
    }
}
