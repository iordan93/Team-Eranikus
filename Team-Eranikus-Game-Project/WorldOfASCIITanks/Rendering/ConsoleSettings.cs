using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.Rendering
{
    public static class ConsoleSettings
    {
        public const int ConsoleWidth = 60;
        public const int ConsoleHeight = 40;

        public static void PrepareConsole() 
        {
            // TODO: CursorVisible, colors, etc.
            Console.BufferWidth = Console.WindowWidth = ConsoleHeight;
            Console.BufferHeight = Console.WindowHeight = ConsoleWidth;
            Console.CursorVisible = false;
        }
    }
}
