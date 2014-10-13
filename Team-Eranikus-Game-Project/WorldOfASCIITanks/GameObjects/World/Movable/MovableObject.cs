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

        public abstract void Move(Direction direction, int step = 1);

        public abstract void Attack();
    }
}
