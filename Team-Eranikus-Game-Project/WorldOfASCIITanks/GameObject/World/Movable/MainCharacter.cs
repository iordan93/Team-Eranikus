

namespace WorldOfASCIITanks.GameObject.World.Movable
{
    using WorldOfASCIITanks.GameObject.World.Rendering;
    using WorldOfASCIITanks.Interfaces;

    internal class MainCharacter : GameObject, IMovable
    {
        public int ManaPoints { get; set; }

        public int Experience { get; set; }

        public MainCharacter(MatrixCoords coords)
            :base(coords, new char[,] { {'*'} })
        {

        }

        public int DirectionX
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int DirectionY
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public int Health
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int Attack
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int Defence
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }


        public int Level
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}