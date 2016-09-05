using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace PremiumWebServer.ViewModels
{
    class ConfigViewModel:ViewModelBase
    {
      public  RelayCommand DbConnectCommand { get; set; }
        public static Server.DbServerEstatus DbStatus;
        public ConfigViewModel()
        {
            DbConnectCommand = new RelayCommand(Conectar);
        
                ValidTxt = DbStatus.ToString();
          
        }

        private void Conectar(object obj)
        {
           // if (DbStatus != Server.DbServerEstatus.Activo)
           // {
                var pass = obj as PasswordBox;
                var server = LogingViewModel.newserver;
                server.Mysqlserver = txtMyServer;
                server.Mysqldbuser = txtMyuser;
                server.Mysqldbkey = pass.Password;
                server.Mysqldbport = txtMyPort;
                Properties.Settings.Default.DbKey = pass.Password;
                Properties.Settings.Default.Save();

                DbStatus = server.StartDbService();
            ValidTxt = DbStatus.ToString();
            if (DbStatus==Server.DbServerEstatus.Activo)
            {
                MessageBox.Show("Conexion Realizada", "Conexion", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
            //  }

        }

        public static void MaintainedDbConnect()

        {
            var server = LogingViewModel.newserver;
            server.Mysqlserver = Properties.Settings.Default.DbServer;
            server.Mysqldbuser = Properties.Settings.Default.DbUser;
            server.Mysqldbkey = Properties.Settings.Default.DbKey;
            server.Mysqldbport = Properties.Settings.Default.DbPort;
            DbStatus= server.StartDbService();
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
