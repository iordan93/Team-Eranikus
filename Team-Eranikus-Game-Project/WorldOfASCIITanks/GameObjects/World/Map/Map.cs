using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects.World.Map
{
    public class Map : WorldObject, ICollidable
    {
        public override int Team { get; protected set; }

        public Map():base(null, null)
        {
            // TODO: Implement constructor properly
        }

        public override void Update()
        {
            
        }
    }
}
