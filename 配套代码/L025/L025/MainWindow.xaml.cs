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

namespace L025
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
            text.FontWeight =
                text.FontWeight == FontWeights.Bold ?
                FontWeights.Normal : FontWeights.Bold;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.FontStyle =
                text.FontStyle == FontStyles.Italic ?
                FontStyles.Normal : FontStyles.Italic;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.TextDecorations =
                text.TextDecorations == TextDecorations.Underline ?
                null : TextDecorations.Underline;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (text == null) return;

            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;

            ComboBoxItem comboBoxItem = comboBox.SelectedValue as ComboBoxItem;
            if (comboBoxItem == null) return;

            text.FontSize = int.Parse(comboBoxItem.Content.ToString());

        }
    }
}
