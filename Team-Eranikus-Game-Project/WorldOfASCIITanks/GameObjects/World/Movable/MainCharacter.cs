namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
    using System;

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
            string characterType)
            : base(coords, body, health, manaPoints, attack, defence, experience, level)
        {
            this.Team = 1;
        }

        public override void Attack(IAttacker opponent)
        {
           Knife knife = new Knife();
           opponent.Health = opponent.Health - knife.DamageHealth;
           
        }

        public override void Update()
        {
        }
    }
}