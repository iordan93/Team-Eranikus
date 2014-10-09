namespace WorldOfASCIITanks.Interfaces
{
    public interface IMovable
    {
        int Health { get; set; }
        int Level { get; set; }

        int Attack { get; set; }

        int Defence { get; set; }

        int DirectionX { get; set; }

        int DirectionY { get; set; }

        void Move();
    }
}