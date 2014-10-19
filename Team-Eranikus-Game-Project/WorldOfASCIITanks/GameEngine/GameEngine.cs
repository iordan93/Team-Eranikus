﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.Interfaces;
using System.Threading;

namespace WorldOfASCIITanks.GameEngine
{
    class GameEngine
    {
        private IRenderer renderer;
        private IUserInterface userInterface;
        private List<GameObject> allObjects;

        public GameEngine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
        }

        public void AddObject(GameObject obj)
        {
            this.allObjects.Add(obj);
        }
        public void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

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
