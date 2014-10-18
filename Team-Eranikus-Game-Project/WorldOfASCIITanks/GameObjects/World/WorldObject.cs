using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
