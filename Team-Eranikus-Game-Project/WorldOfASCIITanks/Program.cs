using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.GameObjects.World.Rendering;

namespace WorldOfASCIITanks
{
    internal class Program
    {
        private static void Main()
        {
            MainCharacter hero = new MainCharacter(new MatrixCoords(1,1));
            ConsoleRenderer renderer = new ConsoleRenderer(10, 10);
            MainCharacter hero2 = new MainCharacter(new MatrixCoords(3, 3));
            renderer.EnqueueForRendering(hero2);
            renderer.EnqueueForRendering(hero);
            renderer.RenderAll();
        }
    }
}