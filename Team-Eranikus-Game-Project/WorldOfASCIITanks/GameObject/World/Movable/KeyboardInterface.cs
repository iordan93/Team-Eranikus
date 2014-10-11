using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameOBject.World.Movable
{
    class KeyboardInterface : IUserinterface
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

                if (key.Key == ConsoleKey.A)
                {
                    this.OnLeftPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.D)
                {
                    this.OnRightPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.W)
                {
                    this.OnUpPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.S)
                {
                    this.OnDownPressed(this, new EventArgs());
                }
            }
        }
    }
}
