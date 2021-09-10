using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Encje
{
    class burgers
    {
        public sbyte? Id_burger { get; set; }
        public string Name { get; set; }
        public string Vegan { get; set; }
        public sbyte? Price { get; set; }

        public burgers(MySqlDataReader reader)
        {
            Id_burger = sbyte.Parse(reader["id_burger"].ToString());
            Name=reader["name"].ToString();
            Vegan = reader["vegan"].ToString();
            Price = sbyte.Parse(reader["price"].ToString());
        }

        public burgers(burgers Burgers)
        {
            Id_burger = Burgers.Id_burger;
            Name = Burgers.Name;
            Vegan = Burgers.Vegan;
            Price = Burgers.Price;
        }
    }
}
