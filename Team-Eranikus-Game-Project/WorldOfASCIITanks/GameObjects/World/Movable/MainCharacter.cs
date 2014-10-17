namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using System;

    public class MainCharacter : MovableObject
    {
        public override int Team { get; protected set; }
        public MainCharacter(MatrixCoords coords, char[,] body, int manaPoints)
            : base(coords, body, 100, 1, 20, 20, 1)
        {
            this.ManaPoints = manaPoints;
            this.Team = 1;
        }

        public int ManaPoints { get; set; }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {

        }
    }
}