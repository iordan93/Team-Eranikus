using System.Collections.Generic;
using WorldOfASCIITanks.GameObjects.World;
using WorldOfASCIITanks.GameObjects.World.Items;

namespace WorldOfASCIITanks.Interfaces
{

    public interface IAttacker : IUnit
    {
        Weapon AttackWeapon { get; set; }
    }
}