using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.ViewModel
{
    using Model;
    using Model.Encje;
    using BaseClasses;
    using System.Windows.Input;
    using System.Collections.ObjectModel;

    class OrderList : ViewModelBase
    {
        private Model model = null;
        private ObservableCollection<order_items> Order_items = null;
        private ObservableCollection<orders> Orders = null;
        private ObservableCollection<Names> Namelist = null;


        public OrderList(Model model)
        {
            this.model = model;
            Order_items = model.Order_Items;
            Orders = model.Orders;
            Namelist = model.Namelist;

        }

        public orders CurrentOrder { get; set; }
        public order_items CurrentOrderItem { get; set; }

        public Names CurrentNameList { get; set; }
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
                Order_items= value;
                onPropertyChanged(nameof(orders));
            }
        }

        public ObservableCollection<Names> namelist
        {
            get { return Namelist; }
            set
            {
                namelist = value;
                onPropertyChanged(nameof(Namelist));
            }
        }

        public void RefreshOrders() => Orders = model.Orders;
        public void RefreshOrderItems() => Order_items = model.Order_Items;
        public void RefreshNameList() => Namelist = model.Namelist;

        private ICommand Zorders = null;
        private ICommand Zorderitems = null;
        private ICommand Znamelist = null;
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
                            Namelist = model.Namelist;
                        }
                        ,
                        arg => true);
                return Znamelist;
            }
        }

    }

  }

