using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfASCIITanks.GameObject.World;

namespace WorldOfASCIITanks.Interfaces
{
    interface IRenderer
    {
        void EnqueForRendering(global::WorldOfASCIITanks.GameObject.World.GameObject obj);

        void RenderAll();

        void ClearQueque();
    }
}
