namespace WorldOfASCIITanks.GameObjects.World.Movable
{
    using WorldOfASCIITanks.GameObjects.World.Items;
    using WorldOfASCIITanks.Rendering;

    public class MainCharacter : MovableObject
    {
        public override int Team { get; protected set; }

        public MainCharacter(
            MatrixCoords coords,
            char[,] body,
            int health,
            int manaPoints,
            int attack,
            int experience,
            int level,
            Weapon weapon
           )
            : base(coords, body, health, manaPoints, attack, experience, level, weapon)
        {
            this.Team = 1;
        }

        public override void Update()
        {
        }

        public virtual int AttackModifier(Weapon weapon)
        {
            // depends on level expr...
            int attackMultiplier = 1;
            return attackMultiplier;
        }

        public virtual int SpellCastModifier(Spell spell)
        {
            int spellModifier = 1;
            return spellModifier;
        }
    }
}