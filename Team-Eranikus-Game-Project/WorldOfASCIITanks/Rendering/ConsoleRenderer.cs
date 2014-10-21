using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfASCIITanks.Rendering
{
    public class ConsoleRenderer : IRenderer
    {
        // Everything is done at this class
        private int vision = 6;
        private char[,] world;

        public ConsoleRenderer(int rows, int cols)
        {
            this.world = new char[rows, cols];
            this.ClearQueue();
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
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    char symbol = this.world[row, col];
                    //Console.SetCursorPosition(col, row);
                    //Console.Write(symbol);
                    output.Append(this.world[row, col]);
                }
                //output.AppendLine();
                //Console.Write(output);
                //output.Clear();
            }

            Console.Write(output);
        }

        public void RenderAllVisible(MainCharacter character)
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    if (character.Coords.Row + vision > row &&
                        character.Coords.Row - vision < row &&
                        character.Coords.Col + vision > col &&
                        character.Coords.Col - vision < col)
                    {
                        output.Append(this.world[row, col]);
                    }
                    else
                    {
                        output.Append(" ");
                    }
                }
            }

            Console.Write(output);
        }

        public void ClearQueue()
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
