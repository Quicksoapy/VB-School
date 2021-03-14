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
            //if theres a save file, load it. If there is none, do nothing
            //if DayTime = true, change. If false, nothing
            //Change images + the links
            if (File.Exists("data.txt"))
            {
                string[] saveddata = File.ReadAllLines("data.txt");
                bool loadedbool = bool.Parse(Trimming(saveddata[0]));

                if (loadedbool)
                {
                    Options.DayTime = true;
                    DisplayMode.SetMode(this);
                }
                Loadslot(saveddata[1], 0, File1);
                Loadslot(saveddata[2], 1, File2);
                Loadslot(saveddata[3], 2, File3);
                Loadslot(saveddata[4], 3, File4);
                Loadslot(saveddata[5], 4, File5);
                Loadslot(saveddata[6], 5, File6);
                Loadslot(saveddata[7], 6, File7);
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
            string[] splitted = line.Split('=');
            string trimstring = splitted[1];
            return trimstring.Trim();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = { "DayTime = " + Options.DayTime, "File1 = " + Slots.slottos[0], "File2 = " + Slots.slottos[1], "File3 = " + Slots.slottos[2], "File4 = " + Slots.slottos[3], "File5 = " + Slots.slottos[4], "File6 = " + Slots.slottos[5], "File7 = " + Slots.slottos[6]};
            string DocPath = "";
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(DocPath, "data.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = { "DayTime = false", "File1 = ", "File2 = ", "File3 = ", "File4 = ", "File5 = ", "File6 = ", "File7 = " };
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
            File1.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File2.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File3.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File4.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File5.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File6.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
            File7.Source = new BitmapImage(new Uri("Resources/empty.jpg", UriKind.Relative));
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
            Slots.switcheroo(File1, 0);
        }

        private void btnSlot2(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File2, 1);
        }

        private void btnSlot3(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File3, 2);
        }

        private void btnSlot4(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File4, 3);
        }

        private void btnSlot5(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File5, 4);
        }

        private void btnSlot6(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File6, 5);
        }

        private void btnSlot7(object sender, RoutedEventArgs e)
        {
            Slots.switcheroo(File7, 6);
        }
    }
}
