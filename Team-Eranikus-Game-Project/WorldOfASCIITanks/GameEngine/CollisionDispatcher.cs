﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfASCIITanks.GameEngine
{
    class CollisionDispatcher
    {
        public static void SeeForCollisions(IList<GameObject> allObjects)
        {
            bool[] alreadyCollided = new bool[allObjects.Count];

            for (int firstObject = 0; firstObject < allObjects.Count; firstObject++)
            {
                for (int secondObject = 0; secondObject < allObjects.Count; secondObject++)
                {
                    if (!alreadyCollided[firstObject])
                    {
                        if (allObjects[firstObject].CanCollideWith(allObjects[secondObject]) &&
                            (!(allObjects[firstObject] is Wall) || !(allObjects[secondObject] is Wall)))
                        {
                            alreadyCollided[secondObject] = true;
                            (allObjects[firstObject] as MovableObject).Attack(allObjects[secondObject] as MovableObject);
                            if ((allObjects[firstObject] as MovableObject).Health <= 0)
                            {
                                (allObjects[firstObject] as MovableObject).isAlive = false;
                            }
                            if ((allObjects[secondObject] as MovableObject).Health <= 0)
                            {
                                (allObjects[secondObject] as MovableObject).isAlive = false;
                            }

                        }
                    }
                }
            }
        }

        public static bool SeeForCollisions(int nextRow, int nextCol, List<Wall> walls)
        {
            foreach (var item in walls)
            {
                if (nextRow == item.Coords.Row && nextCol == item.Coords.Col)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
