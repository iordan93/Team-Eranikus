using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Map
{
    public class Map : WorldObject, ICollidable
    {
        public override int Team { get; protected set; }

        public Map(MatrixCoords coords, char[,] body)
            : base(coords, body)
        {
        }

        public override void Update()
        {
        }
    }
}