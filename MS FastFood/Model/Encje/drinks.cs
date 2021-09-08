using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{
    class drinks
    {
        public sbyte? Id_drink { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Iced { get; set; }
        public sbyte? Price { get; set; }

        public drinks(MySqlDataReader reader)
        {
            Id_drink = sbyte.Parse(reader["id_drink"].ToString());
            Name = reader["name"].ToString();
            Size = reader["size"].ToString();
            Iced = reader["size"].ToString();
            Price = sbyte.Parse(reader["price"].ToString());
        }
    }
}
