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
    /// Логика взаимодействия для Login_menu.xaml
    /// </summary>
    public partial class Login_menu : UserControl
    {
        public Login_menu()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler EnterButtonClick;
        public string login;
        public string password;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login = Login_box.Text;
            password = Password_box.Password;
            if (login != null && password != null && login != "" && password != "" && EnterButtonClick != null)
            {
                EnterButtonClick(this, new RoutedEventArgs());
            }
            else
            {
                System.Windows.MessageBox.Show("Логин или пароль пуст");
            }           
        }
    }
}
