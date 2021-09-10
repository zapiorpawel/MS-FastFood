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
        public int Id_burger { get; set; }
        public string Name { get; set; }
        public string Vegan { get; set; }
        public int Price { get; set; }

        public burgers(MySqlDataReader reader)
        {
            Id_burger = int.Parse(reader["id_burger"].ToString());
            Name=reader["name"].ToString();
            Vegan = reader["vegan"].ToString();
            Price = int.Parse(reader["price"].ToString());
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
