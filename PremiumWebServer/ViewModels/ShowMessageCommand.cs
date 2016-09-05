using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PremiumWebServer.ViewModels
{
    class ShowMessageCommand:ICommand
    {
       
        public void Execute(object parameter)
        {
          var x=  parameter as Window;
            x.Show();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
