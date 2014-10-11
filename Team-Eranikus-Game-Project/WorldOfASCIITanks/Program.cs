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
            ConsoleRenderer renderer = new ConsoleRenderer(10, 10);
            MainCharacter hero2 = new MainCharacter(new MatrixCoords(3, 3));
            renderer.EnqueForRendering(hero2);
            renderer.EnqueForRendering(hero);
            renderer.RenderAll();
        }
    }
}