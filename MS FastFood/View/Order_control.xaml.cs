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

namespace MS_FastFood.View
{
    /// <summary>
    /// Logika interakcji dla klasy Order_control.xaml
    /// </summary>
    public partial class Order_control : UserControl
    {
        public Order_control()
        {
            InitializeComponent();
            this.Visibility = Visibility.Hidden;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
