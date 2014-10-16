using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameOBjects.World.Movable
{
    class KeyboardInterface : IUserInterface
    {

        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        //TODO: method is not implemented at MainCharacter and NPC classes
        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                while (Console.KeyAvailable)
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
            }
        }
    }
}
