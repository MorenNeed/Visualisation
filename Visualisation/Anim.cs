using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace Visualisation
{
    internal class Anim
    {
        public ImageSource Old_Source;
        public Effect Old_Effect;
        public DropShadowEffect effect = new DropShadowEffect();
        public Stream imageStreamSource;
        public GifBitmapDecoder decoder;
        public BitmapSource bitmapSource;

        public Anim(string name_file_base, string name_file_gif) 
        {
            Old_Source = new BitmapImage(new Uri($"C:/Users/Alex/source/repos/Visualisation/Visualisation/images/{name_file_base}.png"));
            imageStreamSource = new FileStream($"C:/Users/Alex/source/repos/Visualisation/Visualisation/images/{name_file_gif}.gif", FileMode.Open, FileAccess.Read, FileShare.Read);
            decoder = new GifBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
        }
    }
}
