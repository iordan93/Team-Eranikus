using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public class Warrior : MainCharacter
    {
        public Warrior(MatrixCoords coords, char[,] body)
            : base(coords, body, 80, 20, 1, 10, 0, 1, new BattleAxe())
        {         
        }
    }
}
