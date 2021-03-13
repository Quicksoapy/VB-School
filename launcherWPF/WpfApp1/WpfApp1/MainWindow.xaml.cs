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
using System.Drawing;
using System.IO;

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
            //if theres a save file, load it. If there is none, suck a dick
            //if CumZone = true, change. If false, nothing
            //Change images + the links
            if (File.Exists("data.txt"))
            {
                string[] saveddata = File.ReadAllLines("data.txt");
                bool loadedcum = bool.Parse(Trimming(saveddata[0]));

                if (loadedcum)
                {
                    Options.CumZone = true;
                    DisplayMode.SetMode(this);
                }
                Loadslot(saveddata[1], 0, Cum1);
                Loadslot(saveddata[2], 1, Cum2);
                Loadslot(saveddata[3], 2, Cum3);
                Loadslot(saveddata[4], 3, Cum4);
                Loadslot(saveddata[5], 4, Cum5);
                Loadslot(saveddata[6], 5, Cum6);
                Loadslot(saveddata[7], 6, Cum7);
            }
            
            this.dateText.Content = DateTime.Now.ToString("HH:mm");
        }   

        public void Loadslot(string pathdata, int slotnumber, System.Windows.Controls.Image image)
        {
            pathdata = Trimming(pathdata);
            if (!string.IsNullOrEmpty(pathdata))
            {
                Slots.slottos[slotnumber] = pathdata;
                image.Source = Slots.BitmapToImageSource(System.Drawing.Icon.ExtractAssociatedIcon(pathdata).ToBitmap());
            }
        }

        public string Trimming(string line)
        {
            string[] splitcum = line.Split('=');
            string cumstring = splitcum[1];
            return cumstring.Trim();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = { "CumZone = " + Options.CumZone, "Cum1 = " + Slots.slottos[0], "Cum2 = " + Slots.slottos[1], "Cum3 = " + Slots.slottos[2], "Cum4 = " + Slots.slottos[3], "Cum5 = " + Slots.slottos[4], "Cum6 = " + Slots.slottos[5], "Cum7 = " + Slots.slottos[6]};
            string DocPath = "";
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(DocPath, "data.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = {"CumZone = false", "Cum1 = ", "Cum2 = ", "Cum3 = ", "Cum4 = ", "Cum5 = ", "Cum6 = ", "Cum7 = "};
            string DocPath = "";
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(DocPath, "data.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            Slots.slottos[0] = null;
            Slots.slottos[1] = null;
            Slots.slottos[2] = null;
            Slots.slottos[3] = null;
            Slots.slottos[4] = null;
            Slots.slottos[5] = null;
            Slots.slottos[6] = null;
            Cum1.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum2.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum3.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum4.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum5.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum6.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            Cum7.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
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
        private void Imghandle(int number)
        {
            //yep cock
            if (string.IsNullOrEmpty(Slots.slottos[number]))
            {
                MessageBox.Show("You haven't added a program yet", "no");
            }
            else
            {
                System.Diagnostics.Process.Start(Slots.slottos[number]);
            }
        }
        private void imgSlot1(object sender, RoutedEventArgs e)
        {
            Imghandle(0);
        }
        private void imgSlot2(object sender, RoutedEventArgs e)
        {
            Imghandle(1);
        }
        private void imgSlot3(object sender, RoutedEventArgs e)
        {
            Imghandle(2);
        }
        private void imgSlot4(object sender, RoutedEventArgs e)
        {
            Imghandle(3);
        }
        private void imgSlot5(object sender, RoutedEventArgs e)
        {
            Imghandle(4);
        }
        private void imgSlot6(object sender, RoutedEventArgs e)
        {
            Imghandle(5);
        }
        private void imgSlot7(object sender, RoutedEventArgs e)
        {
            Imghandle(6);
        }

        

        public void btnSlot1(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum1, 0);
        }

        private void btnSlot2(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum2, 1);
        }

        private void btnSlot3(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum3, 2);
        }

        private void btnSlot4(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum4, 3);
        }

        private void btnSlot5(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum5, 4);
        }

        private void btnSlot6(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum6, 5);
        }

        private void btnSlot7(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(Cum7, 6);
        }
    }
}
