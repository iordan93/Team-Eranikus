using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.World.Items.Weapons
{
    public class MagicStaff : Weapon
    {
        public MagicStaff(string name)
            : base(name, 5,20)
        {
        }
    }
}