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
        public static int collsForRenderingStats = 15;
        private int vision = 6;
        private char[,] placeForRenderStats;
        private char[,] world;

        public ConsoleRenderer(int rows, int cols)
        {
            this.world = new char[rows, cols];
            this.placeForRenderStats = new char[rows, cols + collsForRenderingStats];
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

        public void RenderAll(MainCharacter character)
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();
            StringBuilder inventory = new StringBuilder();
            inventory.Append("Items:");
            foreach (var item in character.Inventory)
            {
                inventory.AppendLine(item.Name);
            }
            string heroLevel = "Level: " + character.Level.ToString();
            string heroHealth = "Health: " + character.Health.ToString();
            string heroMana = "Mana: " + character.Mana.ToString();
            string heroAttackPoints = "Attack: " + character.AttackPoints.ToString();
            string heroWeapon = "Weapon: " + character.AttackPoints.ToString();
            string[] asd = new string[2];

            List<string> statsForRender = MakeHeroStats(heroLevel, heroHealth, heroMana, heroAttackPoints);
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    char symbol = this.world[row, col];
                    output.Append(this.world[row, col]);
                }
                if (statsForRender.Count != 0)
                {
                    for (int i = 0; i < statsForRender[0].Length; i++)
                    {
                        output.Append(statsForRender[0][i]);
                    }
                    statsForRender.RemoveAt(0);

                }
                output.Append(Environment.NewLine);
            }

            Console.Write(output);
        }

        public void RenderAllVisible(MainCharacter character)
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();

            string heroLevel = "Level: " + character.Level.ToString();
            string heroHealth = "Health: " + character.Health.ToString();
            string heroMana = "Mana: " + character.Mana.ToString();
            string heroAttackPoints = "Attack: " + character.AttackPoints.ToString();
            //string heroWeapon = "Weapon: " + character.AttackWeapon.ToString();

            List<string> statsForRender = MakeHeroStats(heroLevel, heroHealth,heroMana,  heroAttackPoints);

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
                if (statsForRender.Count != 0)
                {
                    for (int i = 0; i < statsForRender[0].Length; i++)
                    {
                        output.Append(statsForRender[0][i]);
                    }
                    statsForRender.RemoveAt(0);

                }

                output.Append(Environment.NewLine);
            }

            Console.Write(output);
        }

        //public void RenderStats(MainCharacter character)
        //{
        //    StringBuilder output = new StringBuilder();
        //    string heroLevel = "Level: " + character.Level.ToString();
        //    string heroHealth = "Health: " + character.Health.ToString();
        //    string heroMana = "Mana: " + character.ManaPoints.ToString();
        //    string heroAttackPoints = "Attack: " + character.AttackPoints.ToString();
        //    string heroDefensePoints = "Defense: " + character.DefencePoints.ToString();
        //    string heroExperiance = "Experiance: " + character.Experience.ToString();
        //    string heroWeapon = "Weapon: " + character.AttackWeapon.ToString();
            
        //    char[] statsForRender = MakeHeroStats(heroLevel, heroHealth, heroMana, heroAttackPoints, heroDefensePoints, heroExperiance, heroWeapon);

        //    for (int row = 0; row < this.placeForRenderStats.GetLength(0); row++)
        //    {
        //        for (int col = this.world.GetLength(1), endIndex = 0; col < this.placeForRenderStats.GetLength(1) && (endIndex < collsForRenderingStats); col++, endIndex++)
        //        {

        //        }
        //    }
        //    throw new NotImplementedException();
        //}

        private List<string> MakeHeroStats(params string[] a)
        {
            List<string> stats = new List<string>();
            foreach (var item in a)
            {
                stats.Add(item);
            }
            return stats;
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
