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