using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
using WorldOfASCIITanks.GameObjects.World.Items;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public class Thief : MainCharacter
    {       
        public Thief(MatrixCoords coords, char[,] body)
            : base(coords, body, 50, 50, 1, 0, 1, new Knife())
        { 
        }

        public override int AttackModifier(Weapon weapon)
        {
            int attackMultiplier = 1;

            if (weapon is Knife)
            {
                attackMultiplier = attackMultiplier * 3;
            }
            else if (weapon is MagicStaff)
            {
                attackMultiplier = attackMultiplier * 2;
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
