namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using System;

    public class MainCharacter : MovableObject
    {
        public override int Team { get; protected set; }
        public MainCharacter(MatrixCoords coords, char[,] body)
            : base(coords, body, 100, 100, 100, 100, 100, 1)
        {
            this.Team = 1;
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {

        }
    }
}