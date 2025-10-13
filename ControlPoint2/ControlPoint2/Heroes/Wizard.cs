namespace ControlPoint2.Heroes
{
    using ControlPoint2.Interfaces;
    class Wizard : Hero, IMagicUser
    {
        public Wizard(string name)
        {
            Name = name;
            Level = 1;
        }

        public override void UseAbility(string ability)
        {
            switch (ability.ToLower())
            {
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

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a fireball!");
        }

        public void RechargeMana()
        {
            Console.WriteLine($"{Name} meditates to recharge mana.");
        }
    }
}