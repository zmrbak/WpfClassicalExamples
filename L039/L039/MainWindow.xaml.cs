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

namespace L039
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

        public String Department
        {
            get { return "软件工程部"; }
        }

        public String PersonName
        {
            get { return (String)GetValue(PersonNameProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonNameProperty =
            DependencyProperty.Register("PersonName", typeof(String), typeof(MainWindow), 
                new PropertyMetadata(""));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //提交
            MessageBox.Show("hi," + PersonName);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //重置
            PersonName = "";
        }
    }
}
    
