using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MS_FastFood.ViewModel
{
    using MS_FastFood.Model;
    using BaseClasses;
    using System.Windows;

    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Model model = new Model();

        public OrderModificationsVM OrderModifications { get; set; }

        public DBList PList { get; set; }
        public OrderList OList { get; set; }

        public MainViewModel()
        {
            PList = new DBList(model);
            OList = new OrderList(model);
            OrderModifications = new OrderModificationsVM(model);
        }


    }
}
