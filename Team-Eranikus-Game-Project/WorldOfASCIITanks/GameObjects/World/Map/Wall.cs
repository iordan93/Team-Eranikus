using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects.World.Map
{
    public class Wall : Map
    {
        public override int Team
        {
            get
            {
                return base.Team;
            }
            protected set
            {
                base.Team = value;
            }
        }
    }
}