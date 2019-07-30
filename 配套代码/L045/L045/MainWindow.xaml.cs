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

namespace L045
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
                new Employee{ID="EP001",FirstName="F001",LastName="L001",Department="D001"},
                new Employee{ID="EP002",FirstName="F002",LastName="L002",Department="D002"},
                new Employee{ID="EP003",FirstName="F003",LastName="L003",Department="D003"},
                new Employee{ID="EP004",FirstName="F004",LastName="L004",Department="D001"},
                new Employee{ID="EP005",FirstName="F005",LastName="L005",Department="D002"},
                new Employee{ID="EP006",FirstName="F006",LastName="L006",Department="D001"},
                new Employee{ID="EP007",FirstName="F007",LastName="L007",Department="D001"},
                new Employee{ID="EP008",FirstName="F008",LastName="L008",Department="D001"},
                new Employee{ID="EP009",FirstName="F009",LastName="L009",Department="D002"}
            };
            //dataGrid.ItemsSource = Employees;
        }


        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if(cvs!=null && cvs.CanGroup)
            {
                cvs.GroupDescriptions.Clear();
                if(group.IsChecked==true)
                {
                    cvs.GroupDescriptions.Add(new PropertyGroupDescription("Department"));
                }
            }
        }
    }
}
