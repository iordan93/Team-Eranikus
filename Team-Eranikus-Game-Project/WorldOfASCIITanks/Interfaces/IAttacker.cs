namespace WorldOfASCIITanks.Interfaces
{
    public interface IAttacker : IUnit
    {
        void Attack(IAttacker enemy);

        int AttackPoints { get; set; }
    }
}