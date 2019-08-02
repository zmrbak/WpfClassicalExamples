using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace L093
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

            int interation = (to - from) / 100;
            for (int i = from; i <= to; i++)
            {
                if (worker.CancellationPending == true)
                {
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
                if ((i % interation == 0) && (worker != null) && (worker.WorkerReportsProgress == true))
                {
                    worker.ReportProgress(i / interation);
                }
            }
        }
        BackgroundWorker worker = null;
        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(formValue.Text, out int from) && int.TryParse(toValye.Text, out int to))
            {
                calcButton.IsEnabled = false;
                oddResult.Text = "奇数数量:" + 0;
                evenResult.Text = "偶数数量:" + 0;

                worker = new BackgroundWorker();
                worker.WorkerSupportsCancellation = true;
                worker.WorkerReportsProgress = true;
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                worker.ProgressChanged += Worker_ProgressChanged;
                worker.RunWorkerAsync(new Tuple<int, int>(from, to));
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            if (sender is BackgroundWorker worker)
            {
                if (e.Cancelled == true)
                {
                    oddResult.Text = "任已取消!";
                    evenResult.Text = "";
                }
                else
                {
                    oddResult.Text = "奇数数量:" + oddCount;
                    evenResult.Text = "偶数数量:" + evenCount;
                }
                worker.DoWork -= Worker_DoWork;
                worker.RunWorkerCompleted -= Worker_RunWorkerCompleted;
                worker = null;
            }
            calcButton.IsEnabled = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            var args = (Tuple<int, int>)e.Argument;
            CalculateOddEven(args.Item1, args.Item2);

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}

