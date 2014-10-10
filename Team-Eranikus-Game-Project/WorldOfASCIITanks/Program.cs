using WorldOfASCIITanks.GameObject.World;
using WorldOfASCIITanks.GameObject.World.Movable;
using WorldOfASCIITanks.GameObject.World.Rendering;

namespace WorldOfASCIITanks
{
    internal class Program
    {
        private static void Main()
        {
            MainCharacter hero = new MainCharacter(new MatrixCoords(1,1));
            //ConsoleRenderer renderer = new ConsoleRenderer();
            //renderer.EnqueForRendering(hero);
            //renderer.RenderAll();
        }
    }
}