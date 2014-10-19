﻿using System;
using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks
{
    using WorldOfASCIITanks.GameObjects.World.Items;

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
            Console.WriteLine("Please select your Hero: \nPress 1 for  Mage\nPress 2 for  Thief\nPress 3 for  Warrior");
            int choiseHero = int.Parse(Console.ReadLine());
                // TODO implement interface for the choice of type of character
            MainCharacter hero = HeroChoice(choiseHero);

            //gameEngine.AddObject(hero);
            //gameEngine.AddObject(enemy);

            keyboard.OnDownPressed += (sender, eventInfo) => { hero.Move(Direction.Down); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { hero.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { hero.Move(Direction.Right); };
            keyboard.OnUpPressed += (sender, eventInfo) => { hero.Move(Direction.Top); };
            //gameEngine.Run();
        }

        public static MainCharacter HeroChoice(int heroChoice)
        {
            char[,] heroBody = new char[1, 1] { { '*' } };

            if (heroChoice == 1)
            {
                MainCharacter heroMage = new MainCharacter(new MatrixCoords(1, 1), heroBody, 20, 80, 1, 10, 0, 1, "Mage");
                return heroMage;
            }
            if (heroChoice == 2)
            {
                MainCharacter heroThief = new MainCharacter(new MatrixCoords(1, 1), heroBody, 50, 50, 1, 10, 0, 1, "Thief");
                return heroThief;
            }
            if (heroChoice == 3)
            {
                MainCharacter heroWarrior = new MainCharacter(new MatrixCoords(1, 1), heroBody, 80, 20, 1, 10, 0, 1, "Warrior");
                return heroWarrior;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Please choice, 1, 2 or 3");
            }
        }
    }
}