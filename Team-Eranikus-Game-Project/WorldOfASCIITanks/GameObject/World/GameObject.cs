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
        protected char[,] body;
        
        public GameObject(MatrixCoords coords, char[,] body)
        {
            this.TopLeft = coords;
            this.body = body;
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

        public char[,] GetImage()
        {
            char[,] copy = new char[this.body.GetLength(0), this.body.GetLength(1)];

            for (int row = 0; row < copy.GetLength(0); row++)
			{
                for (int col = 0; col < copy.GetLength(1); col++)
			    {
                    copy[row, col] = this.body[row, col];
			    }
			}

            return copy;
        }
    }
}
