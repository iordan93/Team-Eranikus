﻿using System;
using System.Collections.Generic;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) :  base(currentHitPoints, maximumHitPoints)
        {
            this.ID = id;
            this.Name = name;
            this.MaximumDamage = maximumDamage;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.RewardGold = rewardGold;
            this.LootTable = new List<LootItem>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
    }
}