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
    /// Логика взаимодействия для CheckBox_a.xaml
    /// </summary>
    public partial class CheckBox_a : UserControl
    {
        public CheckBox_a()
        {
            InitializeComponent();
        }

        public bool offline { get; set; }
        public bool rememberMe { get; set; }

        //Чек "Оффлайн"
        private void Offline_Checked(object sender, RoutedEventArgs e)
        {
            offline = true;
        }
        //Анчек "Оффлайн"
        private void Offline_UnChecked(object sender, RoutedEventArgs e)
        {
            offline = false;
        }

        //Чек "Помни меня"
        private void RememberMe_Checked(object sender, RoutedEventArgs e)
        {
            rememberMe = true;
        }
        //Анчек "Помни Меня"
        private void RememberMe_UnChecked(object sender, RoutedEventArgs e)
        {
            rememberMe = false;
        }

    }
}
