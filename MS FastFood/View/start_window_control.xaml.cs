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
using MS_FastFood.ViewModel;

namespace MS_FastFood.View
    
{

    /// <summary>
    /// Logika interakcji dla klasy start_window_control.xaml
    /// </summary>
    public partial class start_window_control : UserControl
    {

        public event EventHandler VisibleChanged;


        public start_window_control()
        {
            InitializeComponent();
        }

        private void MenuSlides_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuSlides.SelectedIndex;
            this.Visibility = Visibility.Hidden;
            MoveCursorMenu(index);
        }

        private void Polish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuSlides.SelectedIndex;
            App.changeLanguage("pl-PL");
            MoveCursorMenu(index);
        }

        private void English_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuSlides.SelectedIndex;
            App.changeLanguage("en-EN");
            MoveCursorMenu(index);
        }

        private void MoveCursorMenu(int index)
        {
            Start_transition.OnApplyTemplate();
            OrderGrid.Margin = new Thickness(0, 100 + (60 * index), 0, 0);
        }

    }
}
