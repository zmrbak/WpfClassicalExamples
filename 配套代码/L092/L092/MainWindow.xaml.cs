using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace L092
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

        private int oddCount = 0;
        private int evenCount = 0;

        private void CalculateOddEven(int from, int to)
        {
            oddCount = 0;
            evenCount = 0;
            for (int i = from; i <= to; i++)
            {
                if(tokenSource.IsCancellationRequested)
                {
                    evenCount = -1;
                    oddCount = -1;
                    return;
                }

                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(formValue.Text, out int from) && int.TryParse(toValye.Text, out int to))
            {
                calcButton.IsEnabled = false;
                oddResult.Text = "奇数数量:" + 0;
                evenResult.Text = "偶数数量:" + 0;

                tokenSource = new CancellationTokenSource();

                ThreadPool.QueueUserWorkItem(_ =>
                {
                    CalculateOddEven(from, to);

                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        if (oddCount < 0 || evenCount < 0)
                        {
                            oddResult.Text = "操作已经取消！";
                            evenResult.Text = "";
                        }
                        else
                        {
                            oddResult.Text = "奇数数量:" + oddCount;
                            evenResult.Text = "偶数数量:" + evenCount;
                        }

                        calcButton.IsEnabled = true;
                    }));
                });
            }
        }

        private CancellationTokenSource tokenSource = null;
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if(tokenSource!=null)
            {
                tokenSource.Cancel();
                tokenSource = null;
            }
        }
    }
}

