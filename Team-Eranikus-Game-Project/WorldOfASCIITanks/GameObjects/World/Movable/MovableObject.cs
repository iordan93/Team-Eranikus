using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.Constants;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public abstract class MovableObject : WorldObject, IMovable, IUnit, IAttacker
    {
        private int health;

        private int manaPoints;

        private int attack;

        private int defence;

        private int experience;

        private int level;

        public MovableObject(
            MatrixCoords coords,
            char[,] body,
            int health,
            int manaPoints,
            int attack,
            int defence,
            int experience,
            int level)
            : base(coords, body)
        {
            this.Health = health;
            this.ManaPoints = manaPoints;
            this.AttackPoints = attack;
            this.DefencePoints = defence;
            this.Experience = experience;
            this.Level = level;
        }

        public MovableObject(MatrixCoords coords, char[,] body)
            : this(
                coords,
                body,
                CharacterConstants.HEALTH,
                CharacterConstants.MANAPOINTS,
                CharacterConstants.ATTACKPOINTS,
                CharacterConstants.DEFENCEPOINTS,
                CharacterConstants.EXPERIENCE,
                CharacterConstants.LEVEL)

        {
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }

            set
            {
                this.manaPoints = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return this.attack;
            }

            set
            {
                this.attack = CharacterConstants.ATTACKPOINTS;
            }
        }

        public int DefencePoints
        {
            get
            {
                return this.defence;
            }

            set
            {
                this.defence = value;
            }
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }

            set
            {
                this.experience = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }

            set
            {
                this.level = value;
            }
        }

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

        public abstract void Attack(IAttacker opponent);

        public override void Update()
        {
        }
    }
}