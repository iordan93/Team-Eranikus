using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects.World.Items;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public class Mage : MainCharacter
    {
        public Mage(MatrixCoords coords, char[,] body)
            : base(coords, body, 20, 80, 1, 10, 0, 1, new MagicStaff())
        { 
        }

        public override int AttackModifier(Weapon weapon)
        {
            int attackMultiplier = 1;

            if (weapon is Knife)
            {
                attackMultiplier = attackMultiplier * 2;
            }
            else if (weapon is MagicStaff)
            {
                attackMultiplier = attackMultiplier * 3;
            }
            else if (weapon is BattleAxe)
            {
                attackMultiplier = 1;
            }
            else
            {
                attackMultiplier = 1;
            }

            return attackMultiplier;
        }

    }
}
