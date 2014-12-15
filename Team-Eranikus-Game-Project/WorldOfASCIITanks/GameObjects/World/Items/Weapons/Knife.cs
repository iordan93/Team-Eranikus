namespace WorldOfASCIITanks.GameObjects.World.Items.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name)
            : base(name, 10, 15)
        {
            this.Name = name;
        }
    }
}