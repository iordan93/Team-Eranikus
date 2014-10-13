using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public abstract class CollectableObject : WorldObject, ICollectable
    {
        public CollectableObject()
            : base(null, null)
        {

        }
    }
}
