using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.Interfaces;

namespace WorldOfASCIITanks.GameEngine
{
    class GameEngine
    {
        private IRenderer renderer;
        private IUserinterface userInterface;
        private List<global::WorldOfASCIITanks.GameObject.World.GameObject> allObjects;

        public GameEngine(IRenderer renderer, IUserinterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<global::WorldOfASCIITanks.GameObject.World.GameObject>();
        }

    }
}
