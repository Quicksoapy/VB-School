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
using Microsoft.VisualBasic;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
            
                this.dateText.Content = DateTime.Now.ToString("HH:mm");
            
        }
        
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void mnuOptions_Click(object sender, RoutedEventArgs e)
        {
            new Options(this).Show();
        }

        private void mnuInfo_Click(object sender, RoutedEventArgs e)
        {
            new iNFO().Show();
        }
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            mi.IsSubmenuOpen = true;
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            mi.IsSubmenuOpen = false;
        }

        private void imgSlot1(object sender, RoutedEventArgs e)
        {
            if (slot1 == null)
            {
                MessageBox.Show("You haven't added a program yet", "no");
            }
             else
            {
                System.Diagnostics.Process.Start(slot1);
            }  
        }
        private void imgSlot2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void imgSlot3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void imgSlot4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void imgSlot5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void imgSlot6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void imgSlot7(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public void btnSlot1(object sender, RoutedEventArgs e)
        {
            string slot1 = Interaction.InputBox("Add a program", "Add","");
        }

        private void btnSlot2(object sender, RoutedEventArgs e)
        {
            string slot2 = Interaction.InputBox("Add a program", "Add", "");
        }

        private void btnSlot3(object sender, RoutedEventArgs e)
        {
            string slot3 = Interaction.InputBox("Add a program", "Add", "");
        }

        private void btnSlot4(object sender, RoutedEventArgs e)
        {
            string slot4 = Interaction.InputBox("Add a program", "Add", "");
        }

        private void btnSlot5(object sender, RoutedEventArgs e)
        {
            string slot5 = Interaction.InputBox("Add a program", "Add", "");
        }

        private void btnSlot6(object sender, RoutedEventArgs e)
        {
            string slot6 = Interaction.InputBox("Add a program", "Add", "");
        }

        private void btnSlot7(object sender, RoutedEventArgs e)
        {
            string slot7 = Interaction.InputBox("Add a program", "Add", "");
        }
    }
}
