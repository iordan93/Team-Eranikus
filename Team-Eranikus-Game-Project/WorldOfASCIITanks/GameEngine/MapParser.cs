using System;
using System.Collections.Generic;
using System.IO;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameEngine
{
    public static class MapParser
    {
        private const string MapEnding = "*****";
        private const char Empty = ' ';

        public static IList<WorldObject> ParseMap(string pathName)
        {
            var mapReader = new StreamReader(pathName);
            IList<WorldObject> objects = new List<WorldObject>();
            using (mapReader)
            {
                string line;
                for (int row = 0; (line = mapReader.ReadLine()) != MapEnding; row++)
                {
                    for (int col = 0; col < line.Length; col++)
                    {
                        if (line[col] != Empty)
                        {

                            var currentObject = GetWorldObject(line[col], row, col);
                            objects.Add(currentObject);
                        }
                    }
                }
            }

            return objects;
        }

        private static WorldObject GetWorldObject(char ch, int row, int col)
        {
            var coords = new MatrixCoords(row, col);
            switch (ch)
            {
                case '-':
                    return new Wall(coords, WallType.Horizontal);
                case '|':
                    return new Wall(coords, WallType.Vertical);
                case '+':
                    return new Wall(coords, WallType.Corner);
                default:
                    throw new InvalidOperationException("Invalid character encountered: " + ch + ".");
            }
        }
    }
}
