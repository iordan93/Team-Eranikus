namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;

    public class MainCharacter : MovableObject
    {
        public int ManaPoints { get; set; }

        public int Experience { get; set; }

        //public MainCharacter(MatrixCoords coords)
        //    :base(coords, new char[,] { {'*'} }) // For the beginning '*' could be the symbol of the MainCharacter
        //{
        //}
    }
}