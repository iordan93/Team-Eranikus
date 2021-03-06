﻿namespace Engine
{
    public class Weapon : Item
    {
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
            : base(id, name, namePlural)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }
    }
}