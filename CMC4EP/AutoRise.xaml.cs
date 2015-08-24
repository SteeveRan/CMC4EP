using Ctrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace CMC4EP
{
    /// <summary>
    /// Логика взаимодействия для AutoRise.xaml
    /// </summary>
    public partial class AutoRise : Window
    {
        public AutoRise()
        {
            InitializeComponent();
            //SetWatermark(LoginTextBox, "тест");
        }

        //private const uint ECM_FIRST = 0x1500;
        //private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        //private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        //public static void SetWatermark(this TextBox textBox, string watermarkText)
        //{
        //    HwndSource source = (HwndSource)HwndSource.FromVisual(textBox);
        //    IntPtr hWnd = source.Handle;

        //    SendMessage(hWnd, EM_SETCUEBANNER, 0, watermarkText);
        //}

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 80;
            string login = "zelourt"; //LoginTextBox.Text;
            string password = "12345"; //PassBox.Password;
            if (login != null && password != null && login != "" && password != "")
            {
                HttpQuery.AutoRize(login, password);
                if (User.Auth != null)
                {
                    this.Close();
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Логин или пароль пуст");
            }
        }

        private void GrBtnLog_MouseMove(object sender, MouseEventArgs e)
        {
            //LogIn.FontSize = 45;
        }

        private void GrBtnLog_LostMouseCapture(object sender, MouseEventArgs e)
        {
            //LogIn.FontSize = 40;
        }


        //Методы кнопок и чекбоксов 

        // Кнопка "ВХОД"
        private void E_click(object sender, RoutedEventArgs e)
        {
            HttpQuery.AutoRize(Login_menu_panel.login, Login_menu_panel.password);
            if (User.Auth != null)
            {
                this.Close();
            }

        }

        //Кнопка "Регистрация"

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тест", "Кнопка регистрации", MessageBoxButton.OK);
        }

        //Кнопка "АВТОРИЗАЦИЯ"
        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тест", "Кнопка авторизации", MessageBoxButton.OK);               
        }

        //Чеки
        //За чеки отвечают переменные CheckPanel.rememberMe и CheckPanel.offline 
    }
}
