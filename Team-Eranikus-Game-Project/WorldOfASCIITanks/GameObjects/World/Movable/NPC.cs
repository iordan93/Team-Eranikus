namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.Interfaces;

    public class NPC : MovableObject
    {
        public NPC()
            : base(null, null, 0, 0, 0, 0, 0)
        {
            // TODO: Implement constructor properly
        }

        public override void Move(Direction direction, int step)
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}