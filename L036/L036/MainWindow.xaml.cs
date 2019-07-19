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

namespace L036
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

        private void MyCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var mousePosition = e.GetPosition(myCanvas);
            var square = new Rectangle
            {
                Width = 50,
                Height = 50,
                Fill = new SolidColorBrush(Colors.Red),
                Opacity = new Random().NextDouble()
            };
            Canvas.SetLeft(square, mousePosition.X - 25);
            Canvas.SetTop(square, mousePosition.Y - 25);

            //Grid.SetColumn(square,1);
            //Grid.SetRow(square,1);

            myCanvas.Children.Add(square);
            ;
        }

        private void MyCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.Source is UIElement square)
            {
                myCanvas.Children.Remove(square);
            }
        }
    }
}
