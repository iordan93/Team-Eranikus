using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObjects;

namespace WorldOfASCIITanks.Interfaces
{
    interface IRenderer
    {
        void EnqueueForRendering(GameObject obj);

        void RenderAll();

        void ClearQueque();
    }
}
