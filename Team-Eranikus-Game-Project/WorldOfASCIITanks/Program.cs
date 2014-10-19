using System;
using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks
{
    public class Program
    {
        private static void Main()
        {
            ConsoleSettings.PrepareConsole();

            var gameObjects = MapParser.ParseMap("../../WorldMaps/map.txt");


            //char[,] heroBody = new char[1, 1] { { '*' } };
            //MainCharacter hero = new MainCharacter(new MatrixCoords(1, 1), heroBody);
            KeyboardInterface keyboard = new KeyboardInterface();
            //NPC enemy = new NPC(new MatrixCoords(3, 3), new char[,] { { '@' } });
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            GameEngine.GameEngine gameEngine = new GameEngine.GameEngine(renderer, keyboard);
            foreach (var item in gameObjects)
            {
                renderer.EnqueueForRendering(item);
            }
            renderer.RenderAll();
            //gameEngine.AddObject(hero);
            //gameEngine.AddObject(enemy);

            //keyboard.OnDownPressed += (sender, eventInfo) => { hero.Move(Direction.Down); };
            //keyboard.OnLeftPressed += (sender, eventInfo) => { hero.Move(Direction.Left); };
            //keyboard.OnRightPressed += (sender, eventInfo) => { hero.Move(Direction.Right); };
            //keyboard.OnUpPressed += (sender, eventInfo) => { hero.Move(Direction.Top); };

            //gameEngine.Run();
        }
    }
}