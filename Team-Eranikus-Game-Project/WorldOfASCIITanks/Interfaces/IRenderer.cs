using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfASCIITanks.Interfaces
{
    interface IRenderer
    {
        void EnqueueForRendering(GameObject obj);

        void RenderAll(MainCharacter character);
        void RenderAllVisible(MainCharacter character);


        void ClearQueue();
    }
}
