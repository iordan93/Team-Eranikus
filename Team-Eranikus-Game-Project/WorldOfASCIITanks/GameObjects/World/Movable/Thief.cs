using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;

namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    public class Thief : MainCharacter
    {
        
        
        public Thief(MatrixCoords coords, char[,] body)
            : base(coords, body, 50, 50, 1, 10, 0, 1, new Knife())
        { 
        }

        public override void AttackModifier()
        {
        }
    }
}
