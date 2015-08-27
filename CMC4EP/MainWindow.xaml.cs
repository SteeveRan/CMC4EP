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

using Ctrl;

namespace CMC4EP
{
    public partial class MainWindow : Window
    {
        static string url = "http://doomstal.com/zel/";

        
        public MainWindow()
        {
            AutoRise windowar = new AutoRise();
            windowar.ShowDialog();
            if (User.Auth != null)
            {
                InitializeComponent();
            }
            else
            {
                this.Close();
            }

            load_ZAGLUSHKA();
        }

        private void TextBoxSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
        }


        /// ВСЕЛЕННАЯ КОСТЫЛЕЙ НАЧАЛО
        // Затычка с левыми поняшами для листа, эбаута и тп
        private void load_ZAGLUSHKA()
        {
            // Выдираем из словаря список пони и грузим его в search_list
            Bronys _l = new Bronys();
            ICollection<Brony> _value = Default_list.Values;
            foreach (Brony _p in _value)
            {
                _l.Add(new Brony(_p.Name, _p.pType, _p.isActive));
            }
            if (P_list != null) P_list.changePoniesList(_l);

            // Выдираем из словаря список пони и грузим его в friend_list
            MyFriends _fl = new MyFriends();
            ICollection<MyFriend> _fvalue = Default_friend_list.Values;
            foreach (MyFriend _f in _fvalue)
            {
                _fl.Add(_f);
            }
            if (FriendList != null) FriendList.ChangeFriendsList(_fl);

        }
        // Затычка для листа поиска

        Dictionary<string, Brony> Default_list = new Dictionary<string, Brony>
        {
            {"Pinkie", new Brony("Pinkie","Pinkie pie is watching you forever",pony_type.earthpony,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/pinkie.png", UriKind.RelativeOrAbsolute)))},
            {"Twilight", new Brony("Twilight","All the ponies in this town are crazy! Do you know what time it is?!",pony_type.unihorn,user_type.helper,true,new BitmapImage(new Uri("/CMC4EP;component/Media/twilight.png", UriKind.RelativeOrAbsolute)))},
            {"Applejack", new Brony("Applejack","Soup's on, everypony!",pony_type.earthpony,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/applejack.png", UriKind.RelativeOrAbsolute)))},
            {"Rainbow Dash", new Brony("Rainbow Dash","Hey. I could clear this sky in ten seconds flat",pony_type.pegasus,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/rainbow.png", UriKind.RelativeOrAbsolute)))},
            {"Fluttershy", new Brony("Fluttershy","You're going to fucking love me",pony_type.pegasus,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/fluttershy.png", UriKind.RelativeOrAbsolute)))},
            {"Rarity", new Brony("Rarity","Pegasi are BRUTES!!",pony_type.unihorn,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/rarity.png", UriKind.RelativeOrAbsolute)))},
            {"Spike", new Brony("Spike","",pony_type.special,user_type.coder,false,new BitmapImage(new Uri("/CMC4EP;component/Media/spike.jpg", UriKind.RelativeOrAbsolute)))},
            {"Derpy", new Brony("Derpy","Derp!!!",pony_type.pegasus,user_type.coder,true,new BitmapImage(new Uri("/CMC4EP;component/Media/derp.jpg", UriKind.RelativeOrAbsolute)))}
        };

        Dictionary<string, MyFriend> Default_friend_list = new Dictionary<string, MyFriend>
        {
            {"Applejack", new MyFriend("Applejack","Soup's on, everypony!",pony_type.earthpony,user_type.player,true,new BitmapImage(new Uri("/CMC4EP;component/Media/applejack.png", UriKind.RelativeOrAbsolute)))},
            {"Spike", new MyFriend("Spike","",pony_type.special,user_type.coder,false,new BitmapImage(new Uri("/CMC4EP;component/Media/spike.jpg", UriKind.RelativeOrAbsolute)))},
            {"Derpy", new MyFriend("Derpy","Derp!!!",pony_type.pegasus,user_type.coder,true,new BitmapImage(new Uri("/CMC4EP;component/Media/derp.jpg", UriKind.RelativeOrAbsolute)))}
        };

        private void P_list_ItemSelected(object sender, RoutedEventArgs e)
        {
            if (P_list.selectedPony != null)
            {
                string _currPonyName = P_list.selectedPony;
                Brony _currPonyAbout = Default_list[_currPonyName];
                UInform.changeInfo((Brony)_currPonyAbout);
            }

        }

        private void Chat_button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// ВСЕЛЕННАЯ КОСТЫЛЕЙ КОНЕЦ (конец ли)






        //Кнопка получения списка броней
        //private void GetUserList_Click(object sender, RoutedEventArgs e)
        //{
        //    if (TextBoxSearchUser.Text != "" && TextBoxSearchUser.Text != null && TextBoxSearchUser.Text != " ")
        //    {
        //        UserList.Items.Clear();
        //        List<Users> pp = HttpQuery.GetUsers(TextBoxSearchUser.Text);
        //        foreach (var user in pp)
        //        {
        //            UserList.Items.Add(user.Name);
        //        }
        //    }
        //    else{ MessageBox.Show("Введите имя юзера"); }
        //}

        ////Добавление друга из списка брони
        //private void MI_Addfriend(object sender, RoutedEventArgs e)
        //{
        //    if (UserList_SelectedIndex() != null)
        //    {
        //        List<Users> pp = HttpQuery.GetUsers(UserList_SelectedIndex());
        //        HttpQuery.AddFriend(HttpQuery.finduserid(pp[0].Name));
        //    }
        //    else { MessageBox.Show("Выберите пользователя из списка"); }     
        //}

        ////Отмена заявки на дружбу
        //private void MI_DeleteRequest(object sender, RoutedEventArgs e)
        //{
        //    if (ListBoxRequest_SelectedIndex() != null)
        //    {
        //        List<Users> myfriends = ListMyRequests();
        //        foreach (var user in myfriends)
        //        {
        //            if (user.Name == ListBoxRequest_SelectedIndex())
        //            {
        //                HttpQuery.DeleteFriend(user.Id);
        //            }
        //        }
        //    }
        //    else { MessageBox.Show("Выберите пользователя из списка"); }
        //}

        ////Клик по "Заявки". Получаем список заявок в лстбокс. 
        //private void TabItemRequest_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    ListBoxRequest.Items.Clear();
        //    List<Users> requestuser = ListMyRequests();
        //    if (requestuser != null)
        //    {
        //        foreach (var user in requestuser)
        //        {
        //            ListBoxRequest.Items.Add(user.Name);
        //        }
        //    }
        //}

        ////Заполнение списка подписчиков
        //private void TabItemFollowers_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    ListBoxFollowers.Items.Clear();
        //    List<Users> followersuser = ListMyFollowers();
        //    if (followersuser != null)
        //    {
        //        foreach (var user in followersuser)
        //        {
        //            ListBoxFollowers.Items.Add(user.Name);
        //        }
        //    }
        //}

        //private void MI_AddFollowers(object sender, RoutedEventArgs e)
        //{
        //    if (ListBoxFollowers_SelectedIndex() != null)
        //    {
        //        foreach (var user in ListMyFollowers())
        //        {
        //            if (user.Name == ListBoxFollowers_SelectedIndex())
        //            {
        //                HttpQuery.AddFriend(user.Id);
        //            }
        //        }
        //    }
        //    else { MessageBox.Show("Выберите пользователя из списка"); }            
        //}

        //private void TabItemFriends_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    GetFriends();
        //}

        //public void GetFriends ()
        //{
        //    ListBoxMyFriends.Items.Clear();
        //    List<Users> myfriend = ListMyFriends();

        //    if (myfriend != null)
        //    {
        //        foreach (var user in myfriend)
        //        {
        //            ListBoxMyFriends.Items.Add(user.Name);
        //        }
        //    }
        //}

        //private void MI_DeleteFriend(object sender, RoutedEventArgs e)
        //{
        //    if (ListBoxMyFriends_SelectedIndex() != null)
        //    {
        //        foreach (var user in ListMyFriends())
        //        {
        //            if (user.Name == ListBoxMyFriends_SelectedIndex())
        //            {
        //                HttpQuery.DeleteFriend(user.Id);
        //            }
        //        }
        //    }
        //    else { MessageBox.Show("Выберите пользователя из списка"); }
        //}

        //// блок получения списков друзей, подписчиков, заявок
        //#region

        //public List<Users> ListMyFriends()
        //{
        //    List<Users> myfriend = Methods.SearchUserList(url + "getfriends");
        //    return myfriend;
        //}

        //public List<Users> ListMyFollowers()
        //{
        //    List<Users> followers = Methods.SearchUserList(url + "getfriendrequestsin");
        //    return followers;
        //}

        //public List<Users> ListMyRequests()
        //{
        //    List<Users> requests = Methods.SearchUserList(url + "getfriendrequestsout");
        //    return requests;
        //}

        //#endregion

        //private void Friends_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    GetFriends();
        //}

        //// блок вытягивания выбранного элемента во всех списках
        //#region

        ////Витягуем имя из выбраного елемента в вкладке "Брони"
        //private string UserList_SelectedIndex()
        //{
        //    if (UserList.SelectedItem != null)
        //    {
        //        string id = UserList.SelectedItem.ToString();
        //        return id;
        //    }
        //    else { return null; }
        //}

        ////Витягуем имя из выбраного елемента в списке "Подписчики"
        //private string ListBoxFollowers_SelectedIndex()
        //{
        //    if (ListBoxFollowers.SelectedItem != null)
        //    {
        //        string id = ListBoxFollowers.SelectedItem.ToString();
        //        return id;
        //    }
        //    else { return null; }
        //}

        ////Витягуем имя из выбраного елемента в списке "Мои друзья"
        //private string ListBoxMyFriends_SelectedIndex()
        //{
        //    if (ListBoxMyFriends.SelectedItem != null)
        //    {
        //        string id = ListBoxMyFriends.SelectedItem.ToString();
        //        return id;
        //    }
        //    else { return null; }
        //}

        ////Витягуем имя из выбраного елемента в списке "Заявки"
        //private string ListBoxRequest_SelectedIndex()
        //{
        //    if (ListBoxRequest.SelectedItem != null)
        //    {
        //        string id = ListBoxRequest.SelectedItem.ToString();
        //        return id;
        //    }
        //    else { return null; }
        //}

        //#endregion

        //// блок отправки и получения сообщений
        //#region
        //public void GetMessage (int id)
        //{
        //    MessageListBox.Items.Clear();
        //    List<Messages> messages = HttpQuery.GetMessage(id);
        //    List<Users> users = ListMyFriends();
        //    foreach (var message in messages)
        //    {
        //        foreach (var user in users)
        //        {
        //            if (user.Id == message.Id)
        //            {
        //                MessageListBox.Items.Add(user.Name + " ⇒ " + message.Data);
        //            }

        //            if (User.Id == message.Id)
        //            {
        //                MessageListBox.Items.Add(User.Name + " ⇐ " + message.Data);
        //            }
        //        }
        //    }
        //    MessageListBox.ScrollIntoView(MessageListBox.Items[MessageListBox.Items.Count - 1]);
        //}

        //private void MI_SendMessage(object sender, RoutedEventArgs e)
        //{
        //    if (ListBoxMyFriends_SelectedIndex() != null)
        //    {
        //        List<Users> myfriends = ListMyFriends();
        //        foreach (var user in myfriends)
        //        {
        //            if (user.Name == ListBoxMyFriends_SelectedIndex())
        //            {
        //                GetMessage(user.Id);
        //                Buffer.Id = user.Id;
        //            }
        //        }
        //        TabItemMessage.Focus();
        //    }
        //    else { MessageBox.Show("Выберите пользователя из списка"); }
        //}

        //public void SetMessage()
        //{

        //    if (ToMassageTestBox.Text != null && ToMassageTestBox.Text != " " && ToMassageTestBox.Text != "")
        //    {

        //        if (Buffer.Id != null)
        //        {
        //            string messages = HttpQuery.SendMessage(Buffer.Id, ToMassageTestBox.Text);
        //        }
        //        GetMessage(Buffer.Id);
        //        ToMassageTestBox.Text = null;
        //    }
        //    else { MessageBox.Show("Сообщение пустое"); }
        //}

        //private void ToMassage_Click(object sender, RoutedEventArgs e)
        //{
        //    SetMessage();
        //}

        //private void ToMassageTestBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //SetMessage();
        //}

        //#endregion

        // блок управления окном
        #region 

        private void MaxWindow_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized) SystemCommands.RestoreWindow(this);
            else SystemCommands.MaximizeWindow(this);
        }

        private void MinWindow_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        
        //Перемещение окна
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //Кнопка закрития окна
        private void CloseWindow_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Search_list_Loaded(object sender, RoutedEventArgs e)
        {

        }



        
    }
}
