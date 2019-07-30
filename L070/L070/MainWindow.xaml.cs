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

namespace L070
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
        private void RadioButton_Checked_Red(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearGradientBrush"];
            if(brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightGoldenrodYellow,0),
                        new GradientStop(Colors.Red,1)
                    }
                };
                Resources["myLinearGradientBrush"] = lBrush;
            }
        }

        private void RadioButton_Checked_Green(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearGradientBrush"];
            if (brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightYellow,0),
                        new GradientStop(Colors.Green,1)
                    }
                };
                Resources["myLinearGradientBrush"] = lBrush;
            }
        }

        private void RadioButton_Checked_Blue(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearGradientBrush"];
            if (brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightBlue,0),
                        new GradientStop(Colors.Blue,1)
                    }
                };
                Resources["myLinearGradientBrush"] = lBrush;
            }
        }
    }
}
