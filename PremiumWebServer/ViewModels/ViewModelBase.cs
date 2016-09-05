using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PremiumWebServer.ViewModels
{
   public class ViewModelBase : INotifyPropertyChanged
    {

        public ViewModelBase()
        {
            ErrorValidations = new List<string>();
        }
        private List<string> _ErrorValidations;
        public List<string> ErrorValidations
        {
            get { return _ErrorValidations; }
            set { _ErrorValidations = value; }
        }
        private string _ValidTxt;
        public string ValidTxt
        {
            get { return _ValidTxt; }
            set
            {
                _ValidTxt = value;
                if (_ValidTxt != string.Empty)
                { LogingViewModel.LoaderImagen.Visibility = System.Windows.Visibility.Hidden; }
                NotifyPropertyChanged();
            }

        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
