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
    public class Warrior : MainCharacter
    {
        public Warrior(MatrixCoords coords, char[,] body)
            : base(coords, body, 80, 20, 1, 0, 1, new BattleAxe("qko axe"))
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
                attackMultiplier = attackMultiplier * 1;
            }
            else if (weapon is BattleAxe)
            {
                attackMultiplier = 3;
            }
            else
            {
                attackMultiplier = 1;
            }

            return attackMultiplier;
        }

        public override int SpellCastModifier(Spell spell)
        {
            int spellModifier = 1;


            return spellModifier;
        }

    }
}
