using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldOfASCIITanks
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
