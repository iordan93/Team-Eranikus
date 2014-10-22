namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int minDmg, int maxDmg)
            :base(name)
        {
            this.MinDmg = minDmg;
            this.MaxDmg = maxDmg;
        }
        // no need of fields
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }

    }
}