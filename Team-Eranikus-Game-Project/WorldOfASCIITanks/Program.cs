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
        // helps run the winForm
        [STAThread]
        private static void Main()
        {
            ConsoleSettings.PrepareConsole();
            KeyboardInterface keyboard = new KeyboardInterface();

            Opponent enemy = new Opponent(new MatrixCoords(3, 3), new char[,] { { '@' } }, null);
            
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            
            IList<WorldObject> map = MapParser.ParseMap("../../WorldMaps/map.txt");
            
            GameEngine.GameEngine gameEngine = new GameEngine.GameEngine(renderer, keyboard);

            int heroChosen = 0;
            Console.WriteLine("Please select your Hero: \nPress 1 for  Mage\nPress 2 for  Thief\nPress 3 for  Warrior");
            
            // validates hero choice and let's player choose correctly
            do
            {
                try
                {
                    heroChosen = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please choose 1, 2 or 3");
                }   
                
            } while (!true||heroChosen<1||heroChosen>3);
            
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
            MainCharacter hero = new MainCharacter(new MatrixCoords(1, 1), heroBody, 0, 0, 0, 0, 0, 1, null);
            switch (heroChosen)
            {
                case 1: hero = new MainCharacter(new MatrixCoords(1, 1), heroBody, 20, 80, 1, 10, 0, 1, null);
                        break;
                case 2: hero = new MainCharacter(new MatrixCoords(1, 1), heroBody, 50, 50, 1, 10, 0, 1, null);
                        break;
                case 3: hero = new MainCharacter(new MatrixCoords(1, 1), heroBody, 80, 20, 1, 10, 0, 1, null);
                        break;
            }
            return hero;
        }
    }
}