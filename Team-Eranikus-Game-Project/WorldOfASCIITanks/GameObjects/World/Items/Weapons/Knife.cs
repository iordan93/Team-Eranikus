using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.World.Items.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name)
            : base(name, 10, 15)
        {
            this.Name = name;
        }
    }
}