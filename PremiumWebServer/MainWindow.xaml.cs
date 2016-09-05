using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using PremiumWebServer.ViewModels;
using System.Diagnostics;
using Hardcodet.Wpf.TaskbarNotification;
using System.Windows.Media.Animation;

namespace PremiumWebServer
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
          
            WindowStyle = WindowStyle.ToolWindow;
            ShowMinButton = false;
            ShowMaxRestoreButton = false;
            SetResourceReference(MetroWindow.GlowBrushProperty, "AccentColorBrush");
            ResizeMode = ResizeMode.CanResizeWithGrip;
            LogingViewModel.principalwindow = this;
            InitializeComponent();
            Hide();
            string title = "Premium Web Server";
            string text = "Premium Web Server Esta Activo";
            MyTask.ShowBalloonTip(title, text, BalloonIcon.Info);
            LogingViewModel.LoaderImagen = imgLoader;
           if (Properties.Settings.Default.State == 1)
           {
              LoginModel.MaintenedLoged();
            }
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }


        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel=true;
            Hide();
        }
    }
}
