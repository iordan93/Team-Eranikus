﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.Interfaces
{
    public interface IUnit
    {
        int Health { get; set; }
        int Mana { get; set; }
        int Level { get; set; }
    }
}
