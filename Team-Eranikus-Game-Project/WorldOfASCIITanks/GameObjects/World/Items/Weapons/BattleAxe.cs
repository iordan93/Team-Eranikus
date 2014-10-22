using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.World.Items.Weapons
{
    public class BattleAxe : Weapon
    {

        public BattleAxe(string name)
            : base(name, 15, 5)
        {
        }
    }
}
