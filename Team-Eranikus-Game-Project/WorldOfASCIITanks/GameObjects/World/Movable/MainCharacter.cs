namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
    using System;
    using WorldOfASCIITanks.GameObjects.World.Items;
    using System.Collections.Generic;

    public class MainCharacter : MovableObject
    {
        public override int Team { get; protected set; }

        public MainCharacter(
            MatrixCoords coords,
            char[,] body,
            int health,
            int manaPoints,
            int attack,
            int experience,
            int level,
            Weapon weapon
           )
            : base(coords, body, health, manaPoints, attack, experience, level, weapon)
        {
            this.Team = 1;
            this.Weapons = new List<Weapon>();
            this.Spells = new List<Spell>();
        }

        public IList<Weapon> Weapons { get; set; }

        public IList<Spell> Spells { get; set; }

        public IList<HealingPotion> MyProperty { get; set; }

        public override void Update()
        {
        }

        public virtual int AttackModifier(Weapon weapon)
        {
            // depends on level expr...
            int attackMultiplier = 1;
            return attackMultiplier;
        }

        public virtual void SpellCastModifier()
        {
        }

        public IEnumerable<InventoryItem> Inventory { get; set; }

        private void AddSpell()
        {
            //        if (this.Experience> ...)
            //{
            //     this.Spells.Add();
            //}
            throw new NotImplementedException();
        }
    }
}