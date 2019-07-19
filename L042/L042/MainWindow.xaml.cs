using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace L042
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Employees = new ObservableCollection<Employee>
            {
                new Employee{ FirstName="FirstName_1", LastName="LastName_1", Department="Department_1" },
                new Employee{ FirstName="FirstName_2", LastName="LastName_2", Department="Department_2" },
                new Employee{ FirstName="FirstName_3", LastName="LastName_3", Department="Department_3" },
                new Employee{ FirstName="FirstName_4", LastName="LastName_4", Department="Department_4" },
                new Employee{ FirstName="FirstName_5", LastName="LastName_5", Department="Department_5" },
                new Employee{ FirstName="FirstName_6", LastName="LastName_6", Department="Department_6" },
                new Employee{ FirstName="FirstName_7", LastName="LastName_7", Department="Department_7" },
                new Employee{ FirstName="FirstName_8", LastName="LastName_8", Department="Department_8" }
            };
            dataGrid.ItemsSource = Employees;
        }



        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ;
        }
    }
}
