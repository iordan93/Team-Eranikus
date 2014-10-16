namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.GameEngine;
    using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

    public class NPC : MovableObject
    {
        private string forArtificialInteligance = "right";
        public override int Team { get; protected set; }
        public NPC(MatrixCoords coords, char[,] body)
            : base(coords, body, 100, 1, 2, 5, 1)
        {
            // TODO: Implement constructor properly
            this.Team = 2;
        }


        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override bool CanCollideWith(GameObject otherObject)
        {
            return this.Team != otherObject.Team;
        }


        private void AiOfNPC()
        {
            if (forArtificialInteligance == "right")
            {
                this.Coords.Col++;
                if (this.Coords.Col == ConsoleSettings.ConsoleWidth / 2 + (ConsoleSettings.ConsoleWidth / 4))
                {
                    forArtificialInteligance = "down";
                }
            }
            else if(forArtificialInteligance == "down")
            {
                this.Coords.Row++;
                if (this.Coords.Row == ConsoleSettings.ConsoleHeight / 2 + (ConsoleSettings.ConsoleHeight / 4))
                {
                    forArtificialInteligance = "left";
                }
            }
            else if(forArtificialInteligance == "left")
            {
                this.Coords.Col--;
                if (this.Coords.Col == ConsoleSettings.ConsoleWidth / 2 - (ConsoleSettings.ConsoleWidth / 4))
                {

                    forArtificialInteligance = "up";
                }
            }
            else if(forArtificialInteligance == "up")
            {
                this.Coords.Row--;
                if (this.Coords.Row == ConsoleSettings.ConsoleHeight / 2 - (ConsoleSettings.ConsoleHeight / 4))
                {
                    forArtificialInteligance = "right";
                }
            }
        }

        public override void Update()
        {
            this.AiOfNPC();
        }
    }
}