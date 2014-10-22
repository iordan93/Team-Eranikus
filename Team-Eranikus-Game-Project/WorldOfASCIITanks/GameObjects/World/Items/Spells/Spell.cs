namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class Spell
    {
           public Spell (int damageHealth, int damageMana, int healthIncrease, int opponentAttackDraw)
        {
            this.DamageHealth = damageHealth;
            this.DamageMana = damageMana;
            this.HealthIncrease = healthIncrease;
            this.OpponentAttackDraw = opponentAttackDraw;
             
        }
        // no need of fields
        public int DamageHealth { get; set; }
        public int DamageMana { get; set; }
        public int HealthIncrease { get; set; }
        public int OpponentAttackDraw { get; set; }
    }
}