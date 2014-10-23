﻿using System.Collections.Generic;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Items;

namespace WorldOfASCIITanks.Interfaces
{

    public interface IAttacker : IUnit
    {
        void Attack(IAttacker enemy);

        int AttackPoints { get; set; }
    }
}