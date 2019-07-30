using L074.ViewModels;
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
using System.Windows.Shapes;

namespace L074.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel ViewModel = null;
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = Resources["ViewModel"] as MainWindowViewModel;
            if(ViewModel==null)
            {
                throw new NullReferenceException("ViewModel 不可以为空！");
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                var userDetail = ViewModel.NewUserDedail;

                e.CanExecute =
                    !String.IsNullOrWhiteSpace(userDetail.FirstName)
                    &&
                    !String.IsNullOrWhiteSpace(userDetail.LastName);
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ViewModel.UserCollection.Add(ViewModel.NewUserDedail);
            ViewModel.SelectedUser = ViewModel.NewUserDedail;
            ViewModel.NewUserDedail = new Models.UserModel();        }
    }
}
