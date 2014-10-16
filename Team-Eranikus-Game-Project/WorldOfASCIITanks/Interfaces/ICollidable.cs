using WorldOfASCIITanks.GameObjects;
namespace WorldOfASCIITanks.Interfaces
{
    public interface ICollidable
    {
        bool CanCollideWith(GameObject otherObject);
    }
}