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
using MS_FastFood.Model.Encje;
using System.Collections.ObjectModel;
namespace MS_FastFood.View
{
    /// <summary>
    /// Logika interakcji dla klasy Order_control.xaml
    /// </summary>
    public partial class Order_control : UserControl
    {
        public static string Ti = "Burgers";

        internal static burgers currentBurger;
        internal static drinks currentDrink;
        internal static sets currentSet;

        public Order_control()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }

        private void OrderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ProductTab_GotFocus(object sender, RoutedEventArgs e)
        {
            TabItem ti = ProductTab.SelectedItem as TabItem;
            Ti = (string)ti.Header;
            //MessageBox.Show("This is " + Ti);
        }

        private void DrinksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListView)sender;
            currentDrink = (drinks)item.SelectedItem;
        }


        private void BurgersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListView)sender;
            currentBurger = (burgers)item.SelectedItem;
        }

        private void SetsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListView)sender;
            currentSet = (sets)item.SelectedItem;
        }

        private void Next_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Selection.SelectedIndex;
            this.Visibility = Visibility.Hidden;
            MoveCursorMenu(index);
        }
        private void MoveCursorMenu(int index)
        {
            Start_transition.OnApplyTemplate();
            OCGrid.Margin = new Thickness(0, 100 + (60 * index), 0, 0);
        }
    }
}
