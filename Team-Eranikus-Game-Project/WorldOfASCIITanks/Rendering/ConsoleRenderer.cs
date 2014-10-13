using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.Rendering
{
    public class ConsoleRenderer : IRenderer
    {
        // Everything is done at this class
        private char[,] world;

        public ConsoleRenderer(int width, int height)
        {
            this.world = new char[width, height];
            this.ClearQueque();
        }

        public void EnqueueForRendering(GameObject obj)
        {
            char[,] image = obj.GetImage();

            MatrixCoords topLeft = obj.Coords;
            int rows = image.GetLength(0) + obj.Coords.Row;
            int cols = image.GetLength(1) + obj.Coords.Col;

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
            for (int row = 0; row < ConsoleSettings.ConsoleWidth; row++)
            {
                for (int col = 0; col < ConsoleSettings.ConsoleHeight; col++)
                {
                    output.Append(this.world[row, col]);
                }
                if (row != ConsoleSettings.ConsoleHeight - 1)
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
