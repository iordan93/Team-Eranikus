using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class HealingPotion : Potion
    {
        public HealingPotion(int amountToHeal)
        {
            this.AmountToHeal = amountToHeal;
        }

        public int AmountToHeal { get; private set; }
    }
}
