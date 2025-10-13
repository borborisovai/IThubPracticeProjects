namespace ControlPoint2.Heroes
{
    using ControlPoint2.Interfaces;
    class Paladin : Hero, IPhysicalFighter, IMagicUser
    {
        public Paladin(string name)
        {
            Name = name;
            Level = 1;
        }

        public override void UseAbility(string ability)
        {
            switch (ability.ToLower())
            {
                case "attack":
                    Attack();
                    break;
                case "defend":
                    Defend();
                    break;
                case "castspell":
                    CastSpell();
                    break;
                case "rechargemana":
                    RechargeMana();
                    break;
                default:
                    Console.WriteLine($"{Name} doesn't know this ability.");
                    break;
            }
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with a sword!");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} defends with a shield!");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a healing spell!");
        }

        public void RechargeMana()
        {
            Console.WriteLine($"{Name} prays to recharge mana!");
        }
    }
}