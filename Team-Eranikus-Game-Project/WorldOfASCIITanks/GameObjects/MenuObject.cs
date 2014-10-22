using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.GameObjects.Menu
{
    public abstract class MenuObject : GameObject
    {
        public MenuObject()
            : base(null, null)
        {
        }
    }
}
