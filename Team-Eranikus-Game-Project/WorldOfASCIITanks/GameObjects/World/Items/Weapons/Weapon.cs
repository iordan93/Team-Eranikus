namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class Weapon
    {
        public Weapon(int damageHealth, int damageMana)
        {
            this.DamageHealth = damageHealth;
            this.DamageMana = damageMana;
        }
        // no need of fields
        public int DamageHealth { get; set; }
        public int DamageMana { get; set; }

    }
}