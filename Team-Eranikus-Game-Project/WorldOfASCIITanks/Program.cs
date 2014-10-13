using System;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks
{
    public class Program
    {
        private static void Main()
        {
            ConsoleSettings.PrepareConsole();

            char[,] heroBody = new char[1, 1] { { '*' } };
            MainCharacter hero = new MainCharacter(new MatrixCoords(1,1), heroBody, 10);

            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleWidth, ConsoleSettings.ConsoleHeight);
            renderer.EnqueueForRendering(hero);
            renderer.RenderAll();

        }
    }
}