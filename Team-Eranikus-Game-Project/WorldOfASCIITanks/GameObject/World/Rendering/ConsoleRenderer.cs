using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObject.World.Rendering;
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
            char[,] image = obj.GetImage();

            MatrixCoords topLeft = obj.TopLeft;
            int rows = image.GetLength(0) + obj.TopLeft.Row;
            int cols = image.GetLength(1) + obj.TopLeft.Col;

            for (int row = topLeft.Row, imageRow = 0; row < rows; row++, imageRow++)
            {
                for (int col = topLeft.Col, imageCol = 0; col < cols; col++, imageCol++)
                {
                    this.world[row, col] = image[imageRow, imageCol];
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    output.Append(this.world[row, col]);
                }
                output.AppendLine();
            }
            Console.Write(output);
        }

        public void ClearQueque()
        {
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    this.world[row, col] = ' ';
                }
            }
        }
    }
}
