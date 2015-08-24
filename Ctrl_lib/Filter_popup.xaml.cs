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
    /// Логика взаимодействия для Filter_popup.xaml
    /// </summary>
    public partial class Filter_popup : UserControl
    {
        filter myFilter;

        public Filter_popup()
        {
            myFilter = new filter();
            InitializeComponent();
        }

        private void F_btn_Click(object sender, RoutedEventArgs e)
        {
            pFilter.IsOpen = true;
        }

        private void EP_Checked(object sender, RoutedEventArgs e)
        {
            myFilter.isEartPonySelected = false;
        }

    }

    public class filter
    {
        public filter()
        {
            this.isEartPonySelected = true;
            this.isRegularSelected = true;
            this.isZebraSelected = true;
            this.isUnihornSelected = true;
            this.isPegasusSelected = true;
            this.isBuilderSelected = true;
            this.isCoderSelected = true;
            this.isHelperSelected = true;
            this.isAdminSelected = true;
        }

        public bool isEartPonySelected;
        public bool isRegularSelected;
        public bool isZebraSelected;
        public bool isUnihornSelected;
        public bool isPegasusSelected;
        public bool isBuilderSelected;
        public bool isCoderSelected;
        public bool isHelperSelected;
        public bool isAdminSelected;

        public List<string> list_filter;

    }
}
