using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public class DisplayMode
    {
        public static void DarkMode(Window window)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(0, 4, 37));
            window.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
           
        }
        public static void LightMode(Window window)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(186, 182, 247));
            window.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
        public static void SetMode(Window window, params dynamic[] controls)
        {
            if (Options.CumZone)
            {
                LightMode(window);
                for (int i = 0; i < controls.Length; i++)
                {
                    controls[i].Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                }
            }
            else
            {
                DarkMode(window);
                for (int i = 0; i < controls.Length; i++)
                {
                    controls[i].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                }
            }
        }
    }
}
