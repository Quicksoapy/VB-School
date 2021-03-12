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
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for iNFO.xaml
    /// </summary>
    public partial class iNFO : Window
    {
        public iNFO()
        {

            InitializeComponent();
            if (Options.CumZone)
            {
                this.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0, 4, 37));
            }
        }
        private void lblWebsite(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://quicksoapy.nl/");
        }
        
    }
    
}
