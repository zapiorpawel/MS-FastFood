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
    using System.Windows;

    class Model
    {
        public int OrderID = Rorders.NextID();
        internal int Sum = 0;




        public ObservableCollection<burgers> Burgers { get; set; } = new ObservableCollection<burgers>();
        public ObservableCollection<drinks> Drinks { get; set; } = new ObservableCollection<drinks>();
        public ObservableCollection<order_items> Order_Items { get; set; } = new ObservableCollection<order_items>();
        public ObservableCollection<orders> Orders { get; set; } = new ObservableCollection<orders>();
        public ObservableCollection<sets> Sets { get; set; } = new ObservableCollection<sets>();
        public ObservableCollection<Names> Namelist { get; set; } = new ObservableCollection<Names>();
       
        

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
            //InitializeSum();
        }

        public burgers SearchBurgerByID(int id)
        {
            foreach (var t in Burgers)
            {
                if (t.Id_burger == id)
                    return t;
            }
            return null;
        }

        public drinks SearchDrinkByID(int id)
        {
            foreach (var t in Drinks)
            {
                if (t.Id_drink == id)
                    return t;
            }
            return null;
        }
        public sets SearchSetsByID(int id)
        {
            foreach (var t in Sets)
            {
                if (t.Id_set == id)
                    return t;
            }
            return null;
        }

        public void AddBurgerToOrderItems(burgers burgers)
        {

                order_items OrderItem = new order_items(OrderID, (int)burgers.Id_burger, (int)burgers.Price);
                Names n = new Names(burgers.Name, burgers.Price);
                Namelist.Add(n);
                Sum = Sum + (int)burgers.Price;
                Rorder_items.AddOrderItemsToTheBase(OrderItem);
            

        }

        public void AddDrinkToOrderItems(drinks drinks)
        {
            order_items OrderItem = new order_items(OrderID, (int)drinks.Id_drink, (int)drinks.Price);
            Names n = new Names(drinks.Name,drinks.Price);
            Namelist.Add(n);
            Sum = Sum + (int)drinks.Price;
            Rorder_items.AddOrderItemsToTheBase(OrderItem);
        }

        public void AddSetToOrderItems(sets sets)
        {
            order_items OrderItem = new order_items(OrderID, (int)sets.Id_set, (int)sets.Price);
            Names n = new Names(sets.Name,sets.Price);
            Namelist.Add(n);
            Sum = Sum + (int)sets.Price;

            Rorder_items.AddOrderItemsToTheBase(OrderItem);
        }

        
        public void AddToOrders() //Dodać funkcje sumującą wartość zamówienia 
        {
            orders Orders = new orders(OrderID,1,"cash");
        }

        public int SumToPay()
        {
            return Sum;
        }
    }
}





