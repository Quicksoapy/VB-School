﻿using System;
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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Win32;





namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        
        public static bool DayTime = false;
        public Options(MainWindow mainWindow)
        {
            _mainwindow = mainWindow;
            InitializeComponent();
            DayMode.IsChecked = DayTime;
            NightMode.IsChecked = !DayTime;

        }
        private void rbLight(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            _mainwindow.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            DayMode.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            NightMode.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            DayTime = true;
            BoundNumber = 0;
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).dateText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                }
                if (window.GetType() == typeof(iNFO))
                {
                    (window as iNFO).lblWebsitee.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    (window as iNFO).textthings.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                }

            }
        }

        private void rbDark(object sender, RoutedEventArgs e)
        {
            DisplayMode.DarkMode(this);
            DisplayMode.DarkMode(_mainwindow);
            DayMode.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            NightMode.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            
            DayTime = false;
            BoundNumber = 1;
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).dateText.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                }
            }

        }
        MainWindow _mainwindow;
    }
    public partial class Options : INotifyPropertyChanged
    {

        private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if (_boundNumber != value)
                {
                    _boundNumber = value;
                    OnPropertyChanged("yes");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
