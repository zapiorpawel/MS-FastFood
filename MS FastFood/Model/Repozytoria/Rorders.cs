using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Repozytoria
{
    using Encje;
    using System.Data;
    using System.Windows;

    class Rorders
    {
        public static List<orders> AllOrders()
        {
            List<orders> Orders = new List<orders>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * From orders", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    Orders.Add(new orders(reader));
                connection.Close();
            }
            return Orders;
        }

        public static bool AddOrderToTheBase(orders Orders)
        {
            bool stan = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO 'orders' ('Id_order', 'Amount_to_pay', 'Payment_method')VALUES {Orders.ToInsert()}", connection);
                connection.Open();
                stan = true;
                connection.Close();
            }
            return stan;
        }

        public static int NextID()
        {
            int Nextid;
            using (var connection = DBConnection.Instance.Connection)
            {
                string GETBIGGESTID = $"SELECT MAX(id_order) FROM orders";
                MySqlCommand command = new MySqlCommand(GETBIGGESTID, connection);
                connection.Open();
                string c = command.ExecuteScalar().ToString();
                Nextid = int.Parse(c);
                connection.Close();
                Nextid++;
            }
            return (int)Nextid;
        }
    }
}
