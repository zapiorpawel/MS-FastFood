using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Repozytoria
{
    using Encje;
    static class RBurgers
    {
        public static List<burgers> AllBurgers()
        {
            List<burgers> Burgers = new List<burgers>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * From burgers", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    Burgers.Add(new burgers(reader));
                connection.Close();
            }
            return Burgers;
        }


    }
}
