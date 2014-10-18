using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.World.Items.Weapons
{
    internal class MagicStaff : Weapon
    {
        public MagicStaff(int damageHealth, int damageMana)
            : base(damageHealth, damageMana)
        {
        }
    }
}