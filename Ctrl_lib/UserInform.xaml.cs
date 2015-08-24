using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
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
    /// Логика взаимодействия для UserInform.xaml
    /// </summary>
    public partial class UserInform : UserControl
    {
        Brony currentBrony;
        public event RoutedEventHandler FriendButtonClick;
        public event RoutedEventHandler ChatButtonClick;
        public event RoutedEventHandler ReportButtonClick;


        public UserInform()
        {
            InitializeComponent();
            defaultInfo();
        }

        public void changeInfo(string _name, pony_type _race, user_type _uType, bool _isOnline, string _About, BitmapImage _ava)
        {
            this.currentBrony = new Brony(_name, _About, _race, _uType, "", _isOnline, _ava);
            this.u_Ava.Source = this.currentBrony.Avatar;
            this.u_About.Text = this.currentBrony.AboutBrony;
            this.u_Nick.Content = this.currentBrony.Name; 
        }

        public void changeInfo(Brony _brother)
        {
            this.currentBrony = _brother;
            this.u_Ava.Source = this.currentBrony.Avatar;
            this.u_About.Text = this.currentBrony.AboutBrony;
            this.u_Nick.Content = this.currentBrony.Name;
        }

        public void defaultInfo()
        {
            this.currentBrony = new Brony();
            this.u_Ava.Source = this.currentBrony.Avatar;
            this.u_About.Text = this.currentBrony.AboutBrony;
            this.u_Nick.Content = this.currentBrony.Name;
        }

        private void Friends_btn_Click(object sender, RoutedEventArgs e)
        {
            if (FriendButtonClick != null)
            {
                FriendButtonClick(this, new RoutedEventArgs());
            }
        }

        private void Chat_btn_Click(object sender, RoutedEventArgs e)
        {
            if (ChatButtonClick != null)
            {
                ChatButtonClick(this, new RoutedEventArgs());
            }
        }

        private void Report_btn_Click(object sender, RoutedEventArgs e)
        {
            if (ReportButtonClick != null)
            {
                ReportButtonClick(this, new RoutedEventArgs());
            }
        }
    }


}
