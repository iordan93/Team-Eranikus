namespace Engine
{
    public class HealingPotion : Item
    {
        public HealingPotion(int id, string name, string namePlural, int amountToHeal)
            : base(id, name, namePlural)
        {
            this.AmountToHeal = amountToHeal;
        }

        public int AmountToHeal { get; set; }
    }
}