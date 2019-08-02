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
using System.Windows.Threading;

namespace L094
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private DispatcherTimer dispatcherTimer = null; 
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(dispatcherTimer !=null)
            {
                dispatcherTimer.Start();
                startButton.IsEnabled = false;
                stopButton.IsEnabled = true;
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (dispatcherTimer != null)
            {
                dispatcherTimer.Stop();
                startButton.IsEnabled = true;
                stopButton.IsEnabled = false;
            }
        }
    }
}
