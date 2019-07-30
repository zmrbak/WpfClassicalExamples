using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PrintDialog = System.Windows.Controls.PrintDialog;

namespace L005
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowDlg windowDlg = new WindowDlg();
            windowDlg.ShowDialog();
            lb_DialogResult.Items.Add(windowDlg.DialogResult);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if(openFileDialog.ShowDialog()==true)
            {
                lb_DialogResult.Items.Add(openFileDialog.FileName);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if(saveFileDialog.ShowDialog()==true)
            {
                lb_DialogResult.Items.Add(saveFileDialog.FileName);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog()== true)
            {
                lb_DialogResult.Items.Add("打印已选择");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                lb_DialogResult.Items.Add("字体已选择");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                lb_DialogResult.Items.Add("颜色已选择");
            }
        }
    }
}
