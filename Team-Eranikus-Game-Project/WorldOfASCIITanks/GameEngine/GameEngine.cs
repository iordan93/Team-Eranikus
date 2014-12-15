using System.Collections.Generic;
using System.Threading;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Items.Weapons;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Interfaces;
using WorldOfASCIITanks.Rendering;

namespace WorldOfASCIITanks.GameEngine
{
    internal class GameEngine
    {
        private IRenderer renderer;
        private IUserInterface userInterface;
        private MainCharacter character;
        private List<GameObject> allObjects;
        public static List<Wall> allWalls;
        private IList<WorldObject> map = MapParser.ParseMap("../../WorldMaps/map.txt");

        public GameEngine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            allWalls = new List<Wall>();
        }

        public void AddObject(GameObject obj)
        {
            if (obj is Wall)
            {
                AddWall(obj as Wall);
                this.allObjects.Add(obj);
            }
            else if (obj is MainCharacter)
            {
                character = obj as MainCharacter;
                this.allObjects.Add(obj);
            }
            else
            {
                this.allObjects.Add(obj);
            }
        }

        private void AddWall(Wall wall)
        {
            allWalls.Add(wall);
        }

        public void Run()
        {
            while (true)
            {
                Opponent opponent = new Opponent(new MatrixCoords(2, 2), new char[,] { { '@' } }, new BattleAxe("qko axe"));
                foreach (var item in this.allObjects)
                {
                    if (item is Opponent)
                    {
                        opponent = item as Opponent;
                    }
                }
                this.renderer.RenderAll(character);
                //this.renderer.RenderAllVisible(character);

                Thread.Sleep(150);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                CollisionDispatcher.SeeForCollisions(this.allObjects);

                foreach (var obj in allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }
                this.allObjects.RemoveAll(x => x.isAlive == false);
            }
        }
    }
}