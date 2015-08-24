using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Логика взаимодействия для Search_list.xaml
    /// </summary>
    public partial class Search_list : UserControl
    {
        private Bronys bros
        {
            get;
            set;
        }
        public string selectedPony;
        
        public event RoutedEventHandler ItemSelected;
        public Search_list()
        {
            this.bros = new Bronys();
            InitializeComponent();
        }

        // Метод для обработки выбора итема в листе
        private void ponies_Selected(object sender, SelectionChangedEventArgs args)
        {
            selectedPony = (ponies.SelectedItem as Brony).Name ;    
            if (ItemSelected != null)
            {
                ItemSelected(this, new RoutedEventArgs());
            }
        }

        // Метод обновления листа
        public void changePoniesList(Bronys _bList)
        {
            this.bros = _bList;
            ponies.ItemsSource = this.bros;
            ponies.SelectedIndex = 0;
        }
    }
}
