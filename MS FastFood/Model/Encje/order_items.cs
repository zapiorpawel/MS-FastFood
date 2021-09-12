using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{
    class order_items
    {
        public int Id_order_items { get; set; }
        public int Id_order { get; set; }
        public int? Id_burger { get; set; }
        public int? Id_drink { get; set; }
        public int? Id_set { get; set; }

        public int Price { get; set; }

        public order_items(MySqlDataReader reader)
        {
            Id_order_items = int.Parse(reader["id_order_items"].ToString());
            Id_order = int.Parse(reader["id_order"].ToString());
            Id_burger = int.Parse(reader["id_burger"].ToString());
            Id_drink = int.Parse(reader["id_drink"].ToString());
            Id_set = int.Parse(reader["id_set"].ToString());
            Price = int.Parse(reader["price"].ToString());
        }

        public order_items(int id_order, int? id_burger, int? id_drink, int? id_set, int price)
        {
            Id_order = id_order;
            Id_burger = id_burger;
            Id_drink = id_drink;
            Id_set = id_set;
            Price = price;

        }

        public order_items(order_items order_items)
        {
            Id_order_items = order_items.Id_order_items;
            Id_burger = order_items.Id_burger;
            Id_drink = order_items.Id_drink;
            Id_set = order_items.Id_set;
            Price = order_items.Price;
        }

        public string ToInsert()
        {
            return $"({Id_order_items}, {Id_burger},{Id_drink},{Id_set},{Price})";
        }
    }
}
