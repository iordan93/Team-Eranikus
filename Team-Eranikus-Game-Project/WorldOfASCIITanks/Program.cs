﻿using System;

using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.GameOBjects.World.Movable;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks
{
    using WorldOfASCIITanks.GameObjects.World.Items;

    public class Program
    {
        private static void Main()
        {
            ConsoleSettings.PrepareConsole();

            KeyboardInterface keyboard = new KeyboardInterface();
            NPC enemy = new NPC(new MatrixCoords(3, 3), new char[,] { { '@' } });
            ConsoleRenderer renderer = new ConsoleRenderer(ConsoleSettings.ConsoleHeight, ConsoleSettings.ConsoleWidth);
            GameEngine.GameEngine gameEngine = new GameEngine.GameEngine(renderer, keyboard);

            int choiseHero = int.Parse(Console.ReadLine());
                // TODO implement interface for the choice of type of character
            MainCharacter hero = HeroChoice(choiseHero);

            gameEngine.AddObject(hero);
            gameEngine.AddObject(enemy);

            keyboard.OnDownPressed += (sender, eventInfo) => { hero.Move(Direction.Down); };
            keyboard.OnLeftPressed += (sender, eventInfo) => { hero.Move(Direction.Left); };
            keyboard.OnRightPressed += (sender, eventInfo) => { hero.Move(Direction.Right); };
            keyboard.OnUpPressed += (sender, eventInfo) => { hero.Move(Direction.Top); };

            gameEngine.Run();
        }

        public static MainCharacter HeroChoice(int heroChoice)
        {
            char[,] heroBody = new char[1, 1] { { '*' } };

            if (heroChoice == 1)
            {
                MainCharacter heroMage = new MainCharacter(new MatrixCoords(1, 1), heroBody, 20, 80, 1, 10, 0, 1);
                return heroMage;
            }
            if (heroChoice == 2)
            {
                MainCharacter heroThief = new MainCharacter(new MatrixCoords(1, 1), heroBody, 50, 50, 1, 10, 0, 1);
                return heroThief;
            }
            if (heroChoice == 3)
            {
                MainCharacter heroWarrior = new MainCharacter(new MatrixCoords(1, 1), heroBody, 80, 20, 1, 10, 0, 1);
                return heroWarrior;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Please choice, 1, 2 or 3");
            }
        }
    }
}