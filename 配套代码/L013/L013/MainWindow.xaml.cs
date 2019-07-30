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

namespace L013
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //imageA.Source = "220x220.jpg";
            //imageA.Source = new ImageSourceConverter().ConvertFromString("220x2201.jpg") as ImageSource;
            imageA.Source = new BitmapImage(new Uri("220x220.jpg",UriKind.RelativeOrAbsolute));
        }
    }
}
