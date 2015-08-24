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

namespace Ctrl
{
    /// <summary>
    /// Логика взаимодействия для FriendsList.xaml
    /// </summary>
    public partial class FriendsList : UserControl
    {
        private MyFriends list
        {
            get;
            set;
        }

        public string selectedFriends;

        public event RoutedEventHandler FriendSelected;
        
        public FriendsList()
        {
            this.list = new MyFriends();
            InitializeComponent();
        }

        public void ChangeFriendsList(MyFriends _l)
        {
            this.list = _l;
            friendsList.ItemsSource = this.list;
            friendsList.SelectedIndex = 0;
        }

        private void FriendsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedFriends = (friendsList.SelectedItem as MyFriend).Name;
            if (FriendSelected != null)
            {
                FriendSelected(this, new RoutedEventArgs());
            }
        }
    }
}
