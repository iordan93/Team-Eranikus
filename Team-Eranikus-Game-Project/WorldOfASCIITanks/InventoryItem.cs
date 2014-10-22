using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldOfASCIITanks
{
    public class InventoryItem
    {
        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }

        public Item Details { get; set; }
        public int Quantity { get; set; }

    }
}
