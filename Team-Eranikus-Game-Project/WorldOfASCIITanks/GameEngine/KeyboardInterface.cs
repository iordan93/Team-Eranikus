using System;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    internal class KeyboardInterface : IUserInterface
    {
        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler onPotionPressed;

        //TODO: method is not implemented at MainCharacter and NPC classes
        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                while (Console.KeyAvailable) // for improved character move, not lagging and atc.
                {
                    Console.ReadKey(true);
                }

                if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow)
                {
                    this.OnLeftPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow)
                {
                    this.OnRightPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                {
                    this.OnUpPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
                {
                    this.OnDownPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.P)
                {
                    this.onPotionPressed(this, new EventArgs());
                }
            }
        }
    }
}