using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects.World
{
    public abstract class WorldObject : GameObject, ICollidable
    {
        public WorldObject()
            : base(null, null)
        {

        }
    }
}
