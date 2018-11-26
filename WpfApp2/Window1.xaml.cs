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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            pic01.Background = new ImageBrush(new BitmapImage(new Uri
                (@"C:\Users\HP\Desktop\classWork1\WpfApp2\WpfApp2\Image\01.png", UriKind.Relative)));

            pic02.Background = new ImageBrush(new BitmapImage(new Uri
                (@"C:\Users\HP\Desktop\classWork1\WpfApp2\WpfApp2\Image\02.png", UriKind.Relative)));

            pic03.Background = new ImageBrush(new BitmapImage(new Uri
               (@"C:\Users\HP\Desktop\classWork1\WpfApp2\WpfApp2\Image\03.png", UriKind.Relative)));

            pic04.Background = new ImageBrush(new BitmapImage(new Uri
               (@"C:\Users\HP\Desktop\classWork1\WpfApp2\WpfApp2\Image\04.png", UriKind.Relative)));

            pic05.Background = new ImageBrush(new BitmapImage(new Uri
               (@"C:\Users\HP\Desktop\classWork1\WpfApp2\WpfApp2\Image\05.png", UriKind.Relative)));
        }
    }
}
