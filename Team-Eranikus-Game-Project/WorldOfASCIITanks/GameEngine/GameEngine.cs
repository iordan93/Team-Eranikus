using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.Interfaces;
using System.Threading;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Map;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfASCIITanks.GameEngine
{
    class GameEngine
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
            else if(obj is MainCharacter)
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
                
            }
        }
    }
}
