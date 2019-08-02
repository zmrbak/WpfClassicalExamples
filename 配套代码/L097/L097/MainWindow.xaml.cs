using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace L097
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
        //SetForegroundWindow
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        Process process = null;
        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            process = new Process();
            process.StartInfo.FileName = "iexplore.exe";
            process.StartInfo.Arguments = address.Text;
            process.Start();
        }

        private void FrontButton_Click(object sender, RoutedEventArgs e)
        {
            if (process != null)
            {
                var ptr = process.MainWindowHandle;
                SetForegroundWindow(ptr);
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            if (process != null)
            {
                var ptr = process.MainWindowHandle;
                SetForegroundWindow(ptr);
                SendKeys.SendWait("{F5}");
            }
        }
    }
}
