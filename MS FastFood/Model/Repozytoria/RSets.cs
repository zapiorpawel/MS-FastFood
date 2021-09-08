using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_FastFood.Model.Repozytoria
{
    using Encje;
    class RSets
    {
        public static List<sets> AllSets()
        {
            List<sets> Sets = new List<sets>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * From sets", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    Sets.Add(new sets(reader));
                connection.Close();
            }
            return Sets;
        }
    }
}
