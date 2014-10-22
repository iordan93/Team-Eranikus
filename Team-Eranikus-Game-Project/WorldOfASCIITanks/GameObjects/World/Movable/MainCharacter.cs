namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
    using System;
    using WorldOfASCIITanks.GameObjects.World.Items;

    public class MainCharacter : MovableObject
    {
        public override int Team { get; protected set; }


        public MainCharacter(
            MatrixCoords coords,
            char[,] body,
            int health,
            int manaPoints,
            int attack,
            int defence,
            int experience,
            int level,
            Weapon weapon
           )
            : base(coords, body, health, manaPoints, attack, defence, experience, level, weapon)
        {
            this.Team = 1;
        }

        

        public override void Attack(IAttacker opponent)
        {
            opponent.Health = opponent.Health - AttackPoints*AttackModifier(AttackWeapon);
        }

        public override void Update()
        {
        }

        public virtual int AttackModifier(Weapon weapon)
        {
            int attackMultiplier = 1;
            return attackMultiplier;
        }

        public virtual void SpellCastModifier()
        { 
        }

        public System.Collections.Generic.IEnumerable<InventoryItem> Inventory { get; set; }
    }
}