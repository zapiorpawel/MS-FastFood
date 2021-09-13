using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Repozytoria
{
    using Encje;
    class Rorder_items
    {
        public static List<order_items> AllOrder_items()
        {
            List<order_items> Order_items = new List<order_items>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * From order_items", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    Order_items.Add(new order_items(reader));
                connection.Close();
            }
            return Order_items;
        }
        public static bool AddOrderItemsToTheBase(order_items Order_items)
        {
            bool stan = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO 'order_items' ('Id_order_items', 'Id_product','Price')VALUES {Order_items.ToInsert()}", connection);
                connection.Open();
                stan = true;
                connection.Close();
            }
            return stan;
        }
    }
}
