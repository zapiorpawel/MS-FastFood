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
        public int OrderID = Rorders.NextID();

        public ObservableCollection<burgers> Burgers { get; set; } = new ObservableCollection<burgers>();
        public ObservableCollection<drinks> Drinks { get; set; } = new ObservableCollection<drinks>();
        public ObservableCollection<order_items> Order_Items { get; set; } = new ObservableCollection<order_items>();
        public ObservableCollection<orders> Orders { get; set; } = new ObservableCollection<orders>();
        public ObservableCollection<sets> Sets { get; set; } = new ObservableCollection<sets>();

        public Model()
        {
            var Burgers = RBurgers.AllBurgers();
            foreach (var b in Burgers)
                this.Burgers.Add(b);
            var Drinks = RDrinks.AllDrinks();
            foreach (var d in Drinks)
                this.Drinks.Add(d);
            var Order_items = Rorder_items.AllOrder_items();
            foreach (var oi in Order_items)
                Order_Items.Add(oi);
            var Orders = Rorders.AllOrders();
            foreach (var o in Orders)
                this.Orders.Add(o);
            var Sets = RSets.AllSets();
            foreach (var s in Sets)
                this.Sets.Add(s);

        }

        private burgers SearchBurgerByID(int id)
        {
            foreach (var t in Burgers)
            {
                if (t.Id_burger == id)
                    return t;
            }
            return null;
        }

        private drinks SearchDrinkByID(int id)
        {
            foreach (var t in Drinks)
            {
                if (t.Id_drink == id)
                    return t;
            }
            return null;
        }
        private sets SearchSetsByID(int id)
        {
            foreach (var t in Sets)
            {
                if (t.Id_set == id)
                    return t;
            }
            return null;
        }



        public void AddBurgerDoOrderItems(burgers burgers)
        {
            order_items OrderItem = new order_items(OrderID, burgers.Id_burger,null,null,burgers.Price);
            Rorder_items.AddOrderItemsToTheBase(OrderItem);
        }

        public void AddDrinkToOrderItems(drinks drinks)
        {
            order_items OrderItem = new order_items(OrderID, null, drinks.Id_drink, null, drinks.Price);
            Rorder_items.AddOrderItemsToTheBase(OrderItem);
        }

        public void AddSetToOrderItems(sets sets)
        {
            order_items OrderItem = new order_items(OrderID, null, null, sets.Id_set, sets.Price);
            Rorder_items.AddOrderItemsToTheBase(OrderItem);

        }

        
        public void AddToOrders() //Dodać funkcje sumującą wartość zamówienia 
        {
            orders Orders = new orders(OrderID,1,"Płatność gotówką");
        }




    }
}





