using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObject.World.Rendering;

namespace WorldOfASCIITanks.GameObject.World
{
    abstract class GameObject
    {
        protected MatrixCoords topLeft;
        
        public GameObject(MatrixCoords coords)
        {
            this.TopLeft = coords;
        }
        public MatrixCoords TopLeft
        {
            get
            {
                return new MatrixCoords(topLeft.Row, topLeft.Col);
            }
            protected set
            {
                this.topLeft = new MatrixCoords(value.Row, value.Col);
            }
        }
    }
}
