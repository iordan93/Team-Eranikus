using System;

using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Rendering;
using System.Windows.Forms;

namespace WorldOfASCIITanks
{
    using System.Collections.Generic;
    using WorldOfASCIITanks.GameObjects.World.Items;

    public class Program
    {
        private static void Main()
        {
            ConsoleSettings.PrepareConsole();

            KeyboardInterface keyboard = new KeyboardInterface();
            NPC enemy = new NPC(new MatrixCoords(3, 3), new char[,] { { '@' } }, null);
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            IList<WorldObject> map = MapParser.ParseMap("../../WorldMaps/map.txt");
            GameEngine.GameEngine gameEngine = new GameEngine.GameEngine(renderer, keyboard);

            Console.WriteLine("Please select your Hero: \nPress 1 for  Mage\nPress 2 for  Thief\nPress 3 for  Warrior");
            int heroChosen = int.Parse(Console.ReadLine());
            Console.Clear();
            // TODO implement interface for the choice of type of character
            MainCharacter hero = HeroChoice(heroChosen);
            gameEngine.AddObject(hero);
            gameEngine.AddObject(enemy);
            foreach (var item in map)
            {
                gameEngine.AddObject(item);
            }

            keyboard.OnDownPressed += (sender, eventInfo) => { hero.Move(Direction.Down); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { hero.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { hero.Move(Direction.Right); };
            keyboard.OnUpPressed += (sender, eventInfo) => { hero.Move(Direction.Top); };

            gameEngine.Run();
        }

        public static MainCharacter HeroChoice(int heroChosen)
        {
            char[,] heroBody = new char[1, 1] { { '*' } };

            // TODO: Provide players with their respective default weapons, as needed (instead of null)
            if (heroChosen == 1)
            {
                MainCharacter heroMage = new MainCharacter(new MatrixCoords(1, 1), heroBody, 20, 80, 1, 10, 0, 1, null);
                return heroMage;
            }
            if (heroChosen == 2)
            {
                MainCharacter heroThief = new MainCharacter(new MatrixCoords(1, 1), heroBody, 50, 50, 1, 10, 0, 1, null);
                return heroThief;
            }
            if (heroChosen == 3)
            {
                MainCharacter heroWarrior = new MainCharacter(new MatrixCoords(1, 1), heroBody, 80, 20, 1, 10, 0, 1, null);
                return heroWarrior;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Please choice, 1, 2 or 3");
            }
        }
    }
}