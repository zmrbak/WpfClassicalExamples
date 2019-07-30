using L074.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L074.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            UserCollection = new ObservableCollection<UserModel>
            {
                new UserModel {FirstName="User",LastName="1"},
                new UserModel {FirstName="User",LastName="2"},
                new UserModel {FirstName="User",LastName="3"},
                new UserModel {FirstName="User",LastName="4"},
                new UserModel {FirstName="User",LastName="5"},
                new UserModel {FirstName="User",LastName="6"}
            };
            NewUserDedail = new UserModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private UserModel m_selectedUser;
        public UserModel SelectedUser
        {
            get { return m_selectedUser; }
            set
            {
                m_selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        private ObservableCollection<UserModel> m_userCollection;
        public ObservableCollection<UserModel> UserCollection
        {
            get { return m_userCollection; }
            set
            {
                m_userCollection = value;
                OnPropertyChanged("UserCollection");
            }
        }

        public UserModel NewUserDedail
        {
            get { return m_newUserDedail; }
            set
            {
                m_newUserDedail = value;
                OnPropertyChanged("NewUserDedail");
            }
        }

        private UserModel m_newUserDedail;

    }
}
