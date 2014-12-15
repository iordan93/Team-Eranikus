namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class Mana : Potion
    {
        public Mana(int amount)
        {
            this.Amount = amount;
        }

        public int Amount { get; private set; }
    }
}