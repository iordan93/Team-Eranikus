namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.GameObjects.World.Items;
    using WorldOfASCIITanks.Interfaces;
    using WorldOfASCIITanks.Rendering;

    public class Opponent : MovableObject
    {
        private string forArtificialInteligance = "right";
        public override int Team { get; protected set; }
        public Opponent(MatrixCoords coords, char[,] body, Weapon weapon)
            : base(coords, body, 100, 1, 2, 5, 10, weapon)
        {
            // TODO: Implement constructor properly
            this.Team = 2;
        }

        private void AiOfNPC()
        {
            if (forArtificialInteligance == "right")
            {
                this.Move(Direction.Right);
                if (this.Coords.Col == ConsoleSettings.ConsoleWidth / 2 + (ConsoleSettings.ConsoleWidth / 4))
                {
                    forArtificialInteligance = "down";
                }
            }
            else if(forArtificialInteligance == "down")
            {
                this.Move(Direction.Down);
                if (this.Coords.Row == ConsoleSettings.ConsoleHeight / 2 + (ConsoleSettings.ConsoleHeight / 4))
                {
                    forArtificialInteligance = "left";
                }
            }
            else if(forArtificialInteligance == "left")
            {
                this.Move(Direction.Left);
                if (this.Coords.Col == ConsoleSettings.ConsoleWidth / 2 - (ConsoleSettings.ConsoleWidth / 4))
                {

                    forArtificialInteligance = "up";
                }
            }
            else if(forArtificialInteligance == "up")
            {
                this.Move(Direction.Top);
                if (this.Coords.Row == ConsoleSettings.ConsoleHeight / 2 - (ConsoleSettings.ConsoleHeight / 4))
                {
                    forArtificialInteligance = "right";
                }
            }
        }

        public override void Update()
        {
           // this.AiOfNPC();
        }
    }
}