﻿using System;
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

        private void EngLang_Click(object sender, RoutedEventArgs e)
        {
            App.changeLanguage("en-EN");
        }

        private void PolLang_Click(object sender, RoutedEventArgs e)
        {
            App.changeLanguage("pl-PL");
        }

        private void OpenOrderControl(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;


           

            
            
        }
    }
}
