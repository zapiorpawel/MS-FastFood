using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{
    class sets
    {

        public sbyte? Id_set { get; set; }
        public string Name { get; set; }
        public sbyte? Id_product1 { get; set;}
        public sbyte? Id_product2 { get; set;}
        public sbyte? Price { get; set; }

        public sets(MySqlDataReader reader)
        {
            Id_set = sbyte.Parse(reader["id_set"].ToString());
            Name = reader["name"].ToString();
            Id_product1 = sbyte.Parse(reader["id_product1"].ToString());
            Id_product2 = sbyte.Parse(reader["id_product2"].ToString());
            Price = sbyte.Parse(reader["price"].ToString());
        }
    }
}
