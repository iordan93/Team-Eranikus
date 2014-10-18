namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class Weapon
    {
        private int damageHealth;

        private int damageMana;

        public Weapon(int damageHealth, int damageMana)
        {
            this.DamageHealth = damageHealth;
            this.DamageMana = damageMana;
        }

        public int DamageHealth
        {
            get
            {
                return this.damageHealth;
            }
            set
            {
                this.damageHealth = value;
            }
        }

        public int DamageMana
        {
            get
            {
                return this.damageMana;
            }
            set
            {
                this.damageMana = value;
            }
        }
    }
}