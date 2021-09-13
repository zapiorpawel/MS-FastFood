using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.Model
{
    class Names
    {
        public string name { get; set; }
        public int price { get; set; }

        public Names(string names, int prices)
        {
            name = names;
            price = prices;
        }
    }
}
