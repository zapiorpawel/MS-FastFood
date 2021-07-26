using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MS_FastFood
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {

        internal static void changeLanguage(string version)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(version);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(version);

            var oldWindow = Current.MainWindow;

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();

            oldWindow.Close();
        }
    }
}
