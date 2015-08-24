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
    /// Логика взаимодействия для Regestration_button.xaml
    /// </summary>
    public partial class Regestration_button : UserControl
    {
        public Regestration_button()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler RegButtonClick;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RegButtonClick != null)
            {
                RegButtonClick(this, new RoutedEventArgs());
            }
        }
    }
}
