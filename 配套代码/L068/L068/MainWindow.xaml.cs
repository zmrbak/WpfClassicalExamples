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

namespace L068
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var steamResourceInfo = Application.GetResourceStream(new Uri("Images/imag1.jpg",UriKind.RelativeOrAbsolute));
            var steamResourceInfo = Application.GetResourceStream(new Uri("/ClassLibrary1;component/imag4.jpg", UriKind.RelativeOrAbsolute));

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.StreamSource = steamResourceInfo.Stream;
            bitmapImage.EndInit();
            bitmapImage.Freeze();

            imageTest.Source = bitmapImage;
        }
    }
}
