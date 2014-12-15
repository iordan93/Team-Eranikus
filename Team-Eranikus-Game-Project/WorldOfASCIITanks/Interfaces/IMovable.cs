using WorldOfASCIITanks.GameEngine;

namespace WorldOfASCIITanks.Interfaces
{
    public interface IMovable
    {
        void Move(Direction direction, int step);
    }
}