using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.ViewModel
{
    using Model;
    using Model.Encje;
    using BaseClasses;
    using System.Windows.Input;

    class DBList : ViewModelBase
    {
        private Model model = null;
        private ObservableCollection<burgers> Burgers = null;
        private ObservableCollection<drinks> Drinks = null;
        private ObservableCollection<sets> Sets = null;
        private ObservableCollection<order_items> Order_items = null;
        private ObservableCollection<orders> Orders = null;
        private ObservableCollection<Names> Namelist = null;
        public int Sum = 0;
        // private ObservableCollection<int> Sum = null;

        public DBList(Model model)
        {
            this.model = model;
            Burgers = model.Burgers;
            Drinks = model.Drinks;
            Sets = model.Sets;
            Order_items = model.Order_Items;
            Orders = model.Orders;
            Namelist = model.Namelist;
            Sum = model.Sum;
        }

        public burgers CurrentBurger { get; set; }
        public drinks CurrentDrink { get; set; }
        public sets CurrentSet { get; set; }
        public orders CurrentOrder { get; set; }
        public order_items CurrentOrderItem { get; set; }
        public Names CurrentNameList { get; set; }
        //public int CurrentSum { get; set; }

        public void sum()
        {
                Sum = model.SumToPay();
        }
        public ObservableCollection<burgers> burgers
        {
            get { return Burgers; }
            set
            {
                Burgers = value;
                onPropertyChanged(nameof(burgers));
            }
        }

        public ObservableCollection<drinks> drinks
        {
            get { return Drinks; }
            set
            {
                Drinks = value;
                onPropertyChanged(nameof(drinks));
            }
        }

        public ObservableCollection<sets> sets
        {
            get { return Sets; }
            set
            {
                Sets = value;
                onPropertyChanged(nameof(sets));
            }
        }

        public ObservableCollection<orders> orders
        {
            get { return Orders; }
            set
            {
                Orders = value;
                onPropertyChanged(nameof(orders));
            }
        }

        public ObservableCollection<order_items> order_items
        {
            get { return Order_items; }
            set
            {
                Order_items = value;
                onPropertyChanged(nameof(order_items));
            }
        }

        public ObservableCollection<Names> name_list
        {
            get { return Namelist; }
            set
            {
                Namelist = value;
                onPropertyChanged(nameof(name_list));
            }
        }


        public void RefreshBurgers() => burgers = model.Burgers;
        public void RefreshDrinks() => drinks = model.Drinks;
        public void RefreshSets() => sets = model.Sets;
        public void RefreshOrders() => orders = model.Orders;
        public void RefreshOrderItems() => order_items = model.Order_Items;
        public void RefreshNameList() => name_list = model.Namelist;
        public void RefreshSumList() => Sum = model.Sum;

        private ICommand Zburgers = null;
        private ICommand Zdrinks = null;
        private ICommand Zsets = null;
        private ICommand Zorders = null;
        private ICommand Zorderitems = null;
        private ICommand Znamelist = null;
        private ICommand Zsum = null;
        public ICommand ZBurgers
        {
            get
            {
                if (Zburgers == null)
                    Zburgers = new RelayCommand(
                        arg =>
                        {
                            burgers = model.Burgers;

                        }
                        ,
                        arg => true);
                return Zburgers;
            }
        }
        public ICommand ZDrinks
        {
            get
            {
                if (Zdrinks == null)
                    Zdrinks = new RelayCommand(
                        arg =>
                        {
                            drinks = model.Drinks;
                        },
                        arg => true);
                return Zdrinks;
            }
        }
        public ICommand ZSets
        {
            get
            {
                if (Zsets == null)
                    Zsets = new RelayCommand(
                        arg =>
                        {
                            sets = model.Sets;
                        },
                        arg => true);
                return Zsets;
            }
        }

        public ICommand ZOrders
        {
            get
            {
                if (Zorders == null)
                    Zorders = new RelayCommand(
                        arg =>
                        {
                            orders = model.Orders;
                        }
                        ,
                        arg => true);
                return Zorders;
            }
        }

        public ICommand ZOrders_Items
        {
            get
            {
                if (Zorderitems == null)
                    Zorderitems = new RelayCommand(
                        arg =>
                        {
                            order_items = model.Order_Items;
                        }
                        ,
                        arg => true);
                return Zorderitems;
            }
        }

        public ICommand ZName_list
        {
            get
            {
                if (Znamelist == null)
                    Znamelist = new RelayCommand(
                        arg =>
                        {
                            name_list = model.Namelist;
                        }
                        ,
                        arg => true);
                return Znamelist;
            }
        }
        public ICommand ZSum
        {
            get
            {
                if (Zsum == null)
                    Zsum = new RelayCommand(
                        arg =>
                        {
                            Sum = model.Sum;
                        }
                        ,
                        arg => true);
                return Zsum;
            }
        }

    }
}
