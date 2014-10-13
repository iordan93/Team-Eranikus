using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.Interfaces;

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

    }
}
