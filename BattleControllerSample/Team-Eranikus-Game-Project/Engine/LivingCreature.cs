namespace Engine
{
    public class LivingCreature
    {
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }

        public int CurrentHitPoints { get; set; }

        public int MaximumHitPoints { get; set; }
    }
}