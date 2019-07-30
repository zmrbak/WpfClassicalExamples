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

namespace L004
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.frameA.Source = new Uri("Page1.xaml",UriKind.RelativeOrAbsolute);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.frameA.Source = new Uri("Page2.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.frameA.Source = new Uri("Page3.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
