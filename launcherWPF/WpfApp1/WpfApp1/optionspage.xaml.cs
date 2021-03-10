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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options(MainWindow mainWindow)
        {
            _mainwindow = mainWindow;
            InitializeComponent();
            CumMode.IsChecked = CumZone;
            ShitMode.IsChecked = !CumZone;

        }
        private void rbLight(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            _mainwindow.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            CumZone = true;
        }

        private void rbDark(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(0, 4, 37));
            _mainwindow.Background = new SolidColorBrush(Color.FromRgb(0, 4, 37));
            CumZone = false;
        }
        MainWindow _mainwindow;
        public static bool CumZone = false;

    }
}
