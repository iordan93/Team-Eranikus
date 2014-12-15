namespace WorldOfASCIITanks.Interfaces
{
    public interface IUnit
    {
        int Health { get; set; }

        int Mana { get; set; }

        int Level { get; set; }
    }
}