using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{

    class order_items
    {
        public int? Id_order_items { get; set; }
        public int Id_order { get; set; }
        public int Id_product { get; set; }
        public int Price { get; set; }

        public order_items(MySqlDataReader reader)
        {
            Id_order_items = int.Parse(reader["id_order_items"].ToString());
            Id_order = int.Parse(reader["id_order"].ToString());
            Id_product = int.Parse(reader["id_product"].ToString());
            Price = int.Parse(reader["price"].ToString());
        }

        public order_items(int id_order, int id_product, int price)
        {
            Id_order = id_order;
            Id_product = id_product;
            Price = price;

        }

        public order_items(order_items order_items)
        {
            Id_order = order_items.Id_order;
            Id_product = order_items.Id_product;
            Price = order_items.Price;
        }

        public string ToInsert()
        {
            return $" (NULL, {Id_order}, {Id_product}, {Price})";
        }
    }
}
