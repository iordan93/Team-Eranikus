using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public abstract class MovableObject : WorldObject, IMovable, IUnit, IAttackable
    {
        public MovableObject(MatrixCoords coords, char[,] body, int health, int level, int attack, int defence, int experience)
            : base(coords, body)
        {
            this.Health = health;
            this.Level = level;
            this.AttackPoints = attack;
            this.DefencePoints = defence;
            this.Experience = experience;
        }

        public int Health { get; set; }

        public int Level { get; set; }

        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public int Experience { get; set; }

        public virtual void Move(Direction direction, int step = 1)
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

        public abstract void Attack();

        public override void Update()
        {
            
        }
    }
}
