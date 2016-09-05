using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace PremiumWebServer.ViewModels
{
    class ConfigViewModel:ViewModelBase
    {
      public  RelayCommand DbConnectCommand { get; set; }
 
        public ConfigViewModel()
        {
            DbConnectCommand = new RelayCommand(Conectar);
           
        }

        private void Conectar(object obj)
        {
            var pass = obj as PasswordBox;
            var server = LogingViewModel.newserver;
            server.Mysqlserver = txtMyServer;
            server.Mysqldbuser = txtMyuser;
            server.Mysqldbkey = pass.Password;
            server.Mysqldbport = txtMyPort;
            Properties.Settings.Default.DbKey = pass.Password;
            Properties.Settings.Default.Save();
            
            ValidTxt = server.StartDbService().ToString();

        }

        public static void MaintainedDbConnect()

        {
            var server = LogingViewModel.newserver;
            server.Mysqlserver = Properties.Settings.Default.DbServer;
            server.Mysqldbuser = Properties.Settings.Default.DbUser;
            server.Mysqldbkey = Properties.Settings.Default.DbKey;
            server.Mysqldbport = Properties.Settings.Default.DbPort;
            server.StartDbService();
        }
        
        public string txtMyServer
        {
            get { return Properties.Settings.Default.DbServer; }
            set {
                Properties.Settings.Default.DbServer = value;

                Properties.Settings.Default.Save();
                NotifyPropertyChanged();
            }

        }
       
        public string txtMyuser
        {
            get { return Properties.Settings.Default.DbUser; }
            set {
                Properties.Settings.Default.DbUser = value;
                Properties.Settings.Default.Save();
                NotifyPropertyChanged();
            }

        }

       

        private string _txtMyPort;
        public string txtMyPort
        {
            get { return Properties.Settings.Default.DbPort; }
            set {
                Properties.Settings.Default.DbPort = value;
                Properties.Settings.Default.Save();
                NotifyPropertyChanged();
            }

        }



    }
}
