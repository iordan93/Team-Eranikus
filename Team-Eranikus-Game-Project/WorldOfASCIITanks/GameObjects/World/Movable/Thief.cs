﻿using WorldOfASCIITanks.GameObjects.World.Items;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public class Thief : MainCharacter
    {
        public Thief(MatrixCoords coords, char[,] body)
            : base(coords, body, 50, 50, 1, 0, 1, new Knife("qk knife"))
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

        public override int SpellCastModifier(Spell spell)
        {
            int spellModifier = 2;

            return spellModifier;
        }
    }
}