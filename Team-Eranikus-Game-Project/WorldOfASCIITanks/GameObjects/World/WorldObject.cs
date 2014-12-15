using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World
{
    public abstract class WorldObject : GameObject, ICollidable
    {
        public override int Team { get; protected set; }

        public WorldObject(MatrixCoords coords, char[,] body)
            : base(coords, body)
        {
        }
    }
}