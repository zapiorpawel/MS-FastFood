using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Repozytoria
{
    using Encje;
    static class RDrinks
    {
        public static List<drinks> AllDrinks()
        {
            List<drinks> Drinks = new List<drinks>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * From drinks", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    Drinks.Add(new drinks(reader));
                connection.Close();
            }
            return Drinks;
        }
    }
}
