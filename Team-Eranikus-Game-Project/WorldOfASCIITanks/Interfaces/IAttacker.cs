using WorldOfASCIITanks.GameObjects.World;

namespace WorldOfASCIITanks.Interfaces
{
    public interface IAttacker : IUnit
    {
        void Attack(IAttacker opponent);
    }
}