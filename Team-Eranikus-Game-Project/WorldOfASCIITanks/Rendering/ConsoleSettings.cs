using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.Rendering
{
    public static class ConsoleSettings
    {
        public const int ConsoleWidth = 80;
        public const int ConsoleHeight = 30;

        public static void PrepareConsole() 
        {
            // TODO: CursorVisible, colors, etc.
            Console.BufferWidth = Console.WindowWidth = ConsoleWidth;
            Console.BufferHeight = Console.WindowHeight = ConsoleHeight + 1;
            Console.CursorVisible = false;
        }
    }
}
