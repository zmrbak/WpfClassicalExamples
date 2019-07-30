using L087.EmployeeServiceReference;
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

namespace L087
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



        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));

        private static EmployeeServiceClient client = new EmployeeServiceClient();

        private async void RefreshListAsync()
        {
            var result = await client.GetEmployeesAsync();
            Employees = new ObservableCollection<Employee>(result);
        }

        private async void AddNewEmployeeAsync()
        {
            var employee = new Employee
            {
                ID="EMP"+(Employees.Count+1),
                FirstName="User",
                LastName= (Employees.Count + 1).ToString(),
                Department="软件工程部"
            };

            await client.InsertEmployeeAsync(employee);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RefreshListAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddNewEmployeeAsync();
            RefreshListAsync();
        }
    }
}
