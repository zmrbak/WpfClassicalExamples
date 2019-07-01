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

namespace L009
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("CurrentDomain_UnhandledException，异常已处理！");
            //e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rd_0.IsChecked == true)
            {
                try
                {
                    throw new Exception("引发异常 ");
                }
                catch (Exception)
                {
                    MessageBox.Show("捕捉到异常");
                }
            }

            if (rd_1.IsChecked == true)
            {
                throw new Exception("引发异常 ");
            }
        }
    }
}
