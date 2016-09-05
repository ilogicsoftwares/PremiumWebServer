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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace PremiumWebServer
{
    /// <summary>
    /// Lógica de interacción para WinDbConfig.xaml
    /// </summary>
    public partial class WinDbConfig
    {
        public WinDbConfig()
        {
            WindowStyle = WindowStyle.ToolWindow;
            ShowMinButton = false;
            ShowMaxRestoreButton = false;
            SetResourceReference(MetroWindow.GlowBrushProperty, "AccentColorBrush");
            ResizeMode = ResizeMode.CanResizeWithGrip;
            InitializeComponent();
        }

        private void txtservername_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
