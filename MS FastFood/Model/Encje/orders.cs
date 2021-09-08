using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{
    class orders
    {
        public sbyte? Id_order { get; set; }
        public sbyte? Amount_to_pay { get; set; }
        public string Payment_method { get; set; }

        public orders(MySqlDataReader reader)
        {
            Id_order = sbyte.Parse(reader["id_order"].ToString());
            Amount_to_pay = sbyte.Parse(reader["amount_to_pay"].ToString());
            Payment_method = reader["payment_method"].ToString();
        }

        public orders(sbyte id_order, sbyte amount_to_pay, string payment_method)
        {
            Id_order = id_order;
            Amount_to_pay = amount_to_pay;
            Payment_method = payment_method.Trim();
        }

        public orders(orders orders)
        {
            Id_order = orders.Id_order;
            Amount_to_pay = orders.Amount_to_pay;
            Payment_method = orders.Payment_method;
        }

        public string ToInsert()
        {
            return $"({Id_order}, {Amount_to_pay}, '{Payment_method}')";
        }
    }
}
