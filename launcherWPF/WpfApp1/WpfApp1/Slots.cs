using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using Microsoft.VisualBasic;

namespace WpfApp1
{
    class Slots
    {
        static public string slot1 = string.Empty;
        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
        public void switcheroo(System.Windows.Controls.Image cum1)
        {
            slot1 = Interaction.InputBox("Add a program", "Add","");
            cum1.Source = BitmapToImageSource(System.Drawing.Icon.ExtractAssociatedIcon(slot1).ToBitmap());
    }

 
    }
}
