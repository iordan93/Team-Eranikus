using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.Interfaces
{
    public interface IState
    {
        int Explore();
        int Battle();
    }
}
