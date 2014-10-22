using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameObjects
{
    public abstract class GameObject : IRenderable, ICollidable
    {
        public abstract int Team { get; protected set; } // used for collision
        protected MatrixCoords coords; // X and Y coordinates of the object
        protected char[,] body; // Image of the object, example * or could be more than 1 symbol. It is used for the class ConsoleRenderer
        public bool isAlive { get; set; }
        
        public GameObject(MatrixCoords coords, char[,] body)
        {
            this.Coords = coords;
            this.body = body;
            this.isAlive = true;
        }
        public MatrixCoords Coords
        {
            get
            {
                return this.coords;
            }
            protected set
            {
                this.coords = value;
                //this.coords = new MatrixCoords(value.Row, value.Col);
            }
        }

        public int Width
        {
            get
            {
                return this.body.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return this.body.GetLength(1);
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

        public virtual bool CanCollideWith(GameObject otherObject)
        {

            if (this.Coords.Row == otherObject.Coords.Row && this.Coords.Col == otherObject.Coords.Col)
            {
                return this.Team != otherObject.Team;
            }
            else
            {
                return false;
            }
            
        }

        public abstract void Update();
    }
}
