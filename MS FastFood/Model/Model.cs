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
        public ObservableCollection<burgers> Burgers { get; set; } = new ObservableCollection<burgers>();
        public ObservableCollection<drinks> Drinks { get; set; } = new ObservableCollection<drinks>();
        public ObservableCollection<order_items> Order_Items { get; set; } = new ObservableCollection<order_items>();
        public ObservableCollection<orders> Orders { get; set; } = new ObservableCollection<orders>();
        public ObservableCollection<sets> Sets { get; set; } = new ObservableCollection<sets>();

        public Model()
        {
            var burgers = RBurgers.AllBurgers();
            foreach (var b in burgers)
                Burgers.Add(b);
            var drinks = RDrinks.AllDrinks();
            foreach (var d in drinks)
                Drinks.Add(d);
            var order_items = Rorder_items.AllOrder_items();
            foreach (var oi in order_items)
                Order_Items.Add(oi);
            var orders = Rorders.AllOrders();
            foreach (var o in orders)
                Orders.Add(o);
            var sets = RSets.AllSets();
            foreach (var s in sets)
                Sets.Add(s);

        }
    }
}
