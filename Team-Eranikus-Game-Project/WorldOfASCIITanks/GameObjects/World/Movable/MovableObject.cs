﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorldOfASCIITanks.GameEngine;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.Constants;
using WorldOfASCIITanks.GameObjects.World.Items;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public abstract class MovableObject : WorldObject, IMovable, IUnit, IAttacker
    {
        private List<Item> inventory = new List<Item>();
        private IList<Weapon> weapons = new List<Weapon>();
        private IList<Spell> spells = new List<Spell>();
        private IList<Potion> potions = new List<Potion>();
        public Weapon Weapon { get; set; }
        public int Health { get; set; }
        public int AttackPoints { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Mana { get; set; }

        public List<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
        }
        public MovableObject(MatrixCoords coords, char[,] body,
            int healthPoints,
            int manaPoints,
            int attack,
            int experience,
            int level,
            Weapon weapon)
            : base(coords, body)
        {
            this.Health = healthPoints;
            this.AttackPoints = attack;
            this.Mana = manaPoints;
            this.Level = level;
            this.Experience = experience;
            this.Weapon = weapon;
        }

        #region Properties


        #endregion
        
        public override void Update()
        {
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
                        if (CollisionDispatcher.SeeForCollisions(newRow - step, newCol, GameEngine.GameEngine.allWalls))
                        {
                            break;
                        }
                        newRow -= step;
                    }
                    break;

                case Direction.Right:
                    if (newCol + step < ConsoleSettings.ConsoleWidth)
                    {
                        if (CollisionDispatcher.SeeForCollisions(newRow, newCol + step, GameEngine.GameEngine.allWalls))
                        {
                            break;
                        }
                        newCol += step;
                    }
                    break;

                case Direction.Down:
                    if (newRow + step < ConsoleSettings.ConsoleHeight)
                    {
                        if (CollisionDispatcher.SeeForCollisions(newRow + step, newCol, GameEngine.GameEngine.allWalls))
                        {
                            break;
                        }
                        newRow += step;
                    }
                    break;

                case Direction.Left:
                    if (newCol - step >= 0)
                    {
                        if (CollisionDispatcher.SeeForCollisions(newRow, newCol - step, GameEngine.GameEngine.allWalls))
                        {
                            break;
                        }
                        newCol -= step;
                    }
                    break;

                default:
                    throw new InvalidOperationException("Invalid direction provided.");
            }

            this.Coords.Row = newRow;
            this.Coords.Col = newCol;
        }
        public void AttackWithWeapon(Weapon weapon, IAttacker enemy)
        {
            if (this.weapons.Contains(weapon))
            {
                Random randomWeaponDmg = new Random();
                enemy.Health -= this.AttackPoints + randomWeaponDmg.Next(weapon.MinDmg, weapon.MaxDmg);
            }
            else
            {
                throw new ArgumentException("weapon does not exists in maincharacter or opponent");
            }
        }

        public void AddSpell(Potion item)
        {
            this.potions.Add(item);
        }

        public void AddWeapon(Weapon weapon)
        {
            this.weapons.Add(weapon);
            this.inventory.Add(weapon);
        }

        public void AddPotion(Potion potion)
        {
            this.potions.Add(potion);
        }
    }
}