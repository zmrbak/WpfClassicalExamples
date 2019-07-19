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

namespace L022
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

        int index = 10;
        private void Bt_Add_Click(object sender, RoutedEventArgs e)
        {
            index++;
            lb.Items.Add(new ListBoxItem() {  Content="选项:"+ index });
        }

        private void Bt_Delete_Click(object sender, RoutedEventArgs e)
        {
            List<Object> itmes = new List<object>();
            foreach (var item in lb.SelectedItems)
            {
                itmes.Add(item);
                
            }

            foreach (var item in itmes)
            {
                lb.Items.Remove(item);
            }

        }
    }
}
