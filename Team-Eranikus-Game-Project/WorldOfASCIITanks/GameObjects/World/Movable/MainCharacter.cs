namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.Rendering;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.GameEngine;
    using System;

    public class MainCharacter : MovableObject
    {
        public MainCharacter(MatrixCoords coords, char[,] body, int manaPoints)
            : base(coords, body, 0, 0, 0, 0, 0)
        {
            this.ManaPoints = manaPoints;
        }

        public int ManaPoints { get; set; }

        public override void Move(Direction direction, int step = 1)
        {
            int newRow = this.Coords.Row;
            int newCol = this.Coords.Col;

            switch (direction)
            {
                case Direction.Top:
                    if (newRow - step >= 0)
                    {
                        newRow -= step;
                    }
                    break;
                case Direction.Right:
                    if (newCol + step < ConsoleSettings.ConsoleWidth)
                    {
                        newCol += step;
                    }
                    break;
                case Direction.Down:
                    if (newRow + step < ConsoleSettings.ConsoleHeight)
                    {
                        newRow += step;
                    }
                    break;
                case Direction.Left:
                    if (newCol - step >= 0)
                    {
                        newCol -= step;
                    }
                    break;
                default:
                    throw new InvalidOperationException("Invalid direction provided.");
            }

            this.Coords.Row = newRow;
            this.Coords.Col = newCol;
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}