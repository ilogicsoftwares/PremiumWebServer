using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PremiumWebServer.ViewModels
{
    class LogingViewModel : ViewModelBase
    {
        public static MainWindow principalwindow { get; set; }
        public static Image LoaderImagen { get; set; }
        public RelayCommand IngresarCommand { get; set; }
        public RelayCommand SalirCommand { get; set; }
        public RelayCommand ShowWindowCommand { get; set; }
        public RelayCommand ConfigCommand { get; set; }
        public static Server newserver { get; set; }
        public static User user; 
        private int userexist = 0;
        public LogingViewModel()
        {
            IngresarCommand = new RelayCommand(Ingresar);
            SalirCommand = new RelayCommand(Salir);
            ShowWindowCommand = new RelayCommand(ShowWindow);
            ConfigCommand = new RelayCommand(Config);
           
        }

        private void Config(object obj)
        {
            WinDbConfig config = new WinDbConfig();
            config.Owner = principalwindow;
            config.ShowInTaskbar = false;
            config.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            config.ShowDialog();
        }

        private void ShowWindow(object obj)
        {
            var x = (Window)obj;
            x.Show();
        }

        private void Salir(object obj)
        {
            App.Current.Shutdown();
        }

        private void Ingresar(object obj)
        {
            ShowWait();
           
            var ps = obj as PasswordBox;
            if (userexist == 1)
            {
                goto ValidatePass;
            }
            if (UserTxt == null || ps.Password == string.Empty)
            {
                ValidTxt = "Todos los campos son requeridos";
               
                return;
            }
           
            var Usuariox = Datos.Db.User.Where(x => x.username == UserTxt).FirstOrDefault();
            if (Usuariox ==null)
            {
               
                ValidTxt = "No Existe el Usuario";
             
                userexist = 0;
                return;
            }
            else
            {
                userexist = 1;
                UserLoged = Usuariox;
            }
            
            ValidatePass:

            if (UserLoged.password == ps.Password)
            {   ///LOGED
                principalwindow.txtuser.Visibility = Visibility.Hidden;
                principalwindow.password.Visibility = Visibility.Hidden;
                principalwindow.t1.Visibility = Visibility.Hidden;
                principalwindow.t2.Visibility = Visibility.Hidden;
                principalwindow.button.Visibility = Visibility.Hidden;
                principalwindow.Validator.Visibility = Visibility.Hidden;
              
                LoaderImagen.Visibility = Visibility.Hidden;
                principalwindow.username.Visibility = Visibility.Visible;
                principalwindow.Welcome.Visibility = Visibility.Visible;
                principalwindow.CommandConfig.Visibility = Visibility.Visible;
                principalwindow.CommandPlay.Visibility = Visibility.Visible;
                Properties.Settings.Default.State = 1;
                Properties.Settings.Default.LogedAs = UserLoged.username;
                Properties.Settings.Default.pubkey = UserLoged.pubkey;
                Properties.Settings.Default.subkey = UserLoged.subkey;
                Properties.Settings.Default.Token = UserLoged.tokenid;
                Properties.Settings.Default.Save();
                /////
                ////Server start
                newserver = new Server(UserLoged.pubkey, UserLoged.subkey, UserLoged.tokenid);

            }
            else {
                ValidTxt = "Clave errada";
                
                return;
            }

           

        }
       public void MaintenedLoged()
        {
            UserLoged = new User { username = Properties.Settings.Default.LogedAs,
                                   pubkey= Properties.Settings.Default.pubkey,
                                   subkey= Properties.Settings.Default.subkey,
                                   tokenid= Properties.Settings.Default.Token

            };
            principalwindow.txtuser.Visibility = Visibility.Hidden;
            principalwindow.password.Visibility = Visibility.Hidden;
            principalwindow.t1.Visibility = Visibility.Hidden;
            principalwindow.t2.Visibility = Visibility.Hidden;
            principalwindow.button.Visibility = Visibility.Hidden;
            principalwindow.Validator.Visibility = Visibility.Hidden;

            LoaderImagen.Visibility = Visibility.Hidden;
            principalwindow.username.Visibility = Visibility.Visible;
            principalwindow.Welcome.Visibility = Visibility.Visible;
            principalwindow.CommandConfig.Visibility = Visibility.Visible;
            principalwindow.CommandPlay.Visibility = Visibility.Visible;

            /////
            ////Server start
            newserver = new Server(UserLoged.pubkey, UserLoged.subkey, UserLoged.tokenid);
        }

        private string _UserTxt;
        public string UserTxt
        {
            get { return _UserTxt; }
            set { _UserTxt = value;
                userexist = 0;
                NotifyPropertyChanged();
            }

        }

        private string _PassTxt;
        public string PassTxt
        {
            get { return _PassTxt; }
            set
            {
                _PassTxt = value;
                NotifyPropertyChanged();
            }

        }
        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                                                  new Action(delegate { }));
        }

        public void ShowWait()
        {
          
            

            LoaderImagen.Visibility = Visibility.Visible;
            DoEvents();
        }

        private User _UserLoged;
        public User UserLoged
        {
            get { return _UserLoged; }
            set { _UserLoged = value;
                user = value;
                NotifyPropertyChanged();
            }

        }

    }
}
