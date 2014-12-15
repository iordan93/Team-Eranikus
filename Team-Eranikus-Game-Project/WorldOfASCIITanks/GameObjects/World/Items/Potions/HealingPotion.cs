namespace WorldOfASCIITanks.GameObjects.World.Items
{
    public class HealingPotion : Potion
    {
        public HealingPotion(int amountToHeal)
        {
            this.AmountToHeal = amountToHeal;
        }

        public int AmountToHeal { get; private set; }
    }
}