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

namespace L041
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PersonDetails = new Person { Blog = "http://www.baidu.com", Name = "赵庆明", Experience = 10 };

            DataContext = PersonDetails;
        }


        public Person PersonDetails
        {
            get { return (Person)GetValue(PersonDetailsProperty); }
            set { SetValue(PersonDetailsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonDetails.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonDetailsProperty =
            DependencyProperty.Register("PersonDetails", typeof(Person), typeof(MainWindow), new PropertyMetadata(null));


    }
}
