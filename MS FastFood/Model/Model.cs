using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.Model
{
    using Encje;
    using Repozytoria;
    using System.Collections.ObjectModel;
    class Model
    {
        public ObservableCollection<burgers> burgers { get; set; } = new ObservableCollection<burgers>();
        public ObservableCollection<drinks> drinks { get; set; } = new ObservableCollection<drinks>();
        public ObservableCollection<order_items> order_Items { get; set; } = new ObservableCollection<order_items>();
        public ObservableCollection<orders> orders { get; set; } = new ObservableCollection<orders>();
        public ObservableCollection<sets> sets { get; set; } = new ObservableCollection<sets>();

        public Model()
        {
            var Burgers = RBurgers.AllBurgers();
            foreach (var b in Burgers)
                burgers.Add(b);
            var Drinks = RDrinks.AllDrinks();
            foreach (var d in Drinks)
                drinks.Add(d);
            var Order_items = Rorder_items.AllOrder_items();
            foreach (var oi in Order_items)
                order_Items.Add(oi);
            var Orders = Rorders.AllOrders();
            foreach (var o in Orders)
                orders.Add(o);
            var Sets = RSets.AllSets();
            foreach (var s in Sets)
                sets.Add(s);

        }
    }
}
