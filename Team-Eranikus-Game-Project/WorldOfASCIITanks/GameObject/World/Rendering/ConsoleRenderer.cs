using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObject.World
{
    class ConsoleRenderer : IRenderer
    {
        private char[,] world;

        public ConsoleRenderer(int rows, int cols)
        {
            world = new char[rows, cols];
        }

        public void EnqueForRendering(GameObject obj)
        {
            throw new NotImplementedException();
        }

        public void RenderAll()
        {
            throw new NotImplementedException();
        }

        public void ClearQueque()
        {
            throw new NotImplementedException();
        }
    }
}
