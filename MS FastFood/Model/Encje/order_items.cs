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
        public sbyte? Id_order_items { get; set; }
        public sbyte? Id_order { get; set; }
        public sbyte? Id_burger { get; set; }
        public sbyte? Id_drink { get; set; }
        public sbyte? Id_set { get; set; }

        public sbyte? Price { get; set; }

        public order_items(MySqlDataReader reader)
        {
            Id_order_items = sbyte.Parse(reader["id_order_items"].ToString());
            Id_order = sbyte.Parse(reader["id_order"].ToString());
            Id_burger = sbyte.Parse(reader["id_burger"].ToString());
            Id_drink = sbyte.Parse(reader["id_drink"].ToString());
            Id_set = sbyte.Parse(reader["id_set"].ToString());
            Price = sbyte.Parse(reader["price"].ToString());
        }

        public order_items(sbyte id_order, sbyte id_burger, sbyte id_drink, sbyte id_set, sbyte price)
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
