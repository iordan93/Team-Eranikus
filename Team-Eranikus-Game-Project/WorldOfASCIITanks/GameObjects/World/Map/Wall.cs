using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Map
{
    public class Wall : Map
    {
        public Wall(MatrixCoords coords, WallType type)
            : base(coords, new char[1, 1] { { '\0' } })
        {
            switch (type)
            {
                case WallType.Vertical:
                    this.body = new char[1, 1] { { '|' } };
                    break;
                case WallType.Horizontal:
                    this.body = new char[1, 1] { { '-' } };
                    break;
                case WallType.Corner:
                    this.body = new char[1, 1] { { '+' } };
                    break;
                default:
                    break;
            }
        }

        public override int Team
        {
            get
            {
                return 0;
            }
        }
    }
}