namespace ControlPoint2.Heroes
{
    using ControlPoint2.Interfaces;

    class Bard : Hero, IMagicUser, IDexterityMaster
    {
        public Bard(string name)
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
                case "acrobatic":
                    PerformAcrobaticMove();
                    break;
                case "evade":
                    EvadeAttack();
                    break;
                default:
                    Console.WriteLine($"{Name} doesn't know this ability.");
                    break;
            }
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a magical melody!");
        }

        public void RechargeMana()
        {
            Console.WriteLine($"{Name} recharges mana with a soothing tune!");
        }

        public void PerformAcrobaticMove()
        {
            Console.WriteLine($"{Name} performs an elegant dance move!");
        }

        public void EvadeAttack()
        {
            Console.WriteLine($"{Name} gracefully evades the attack!");
        }
    }
}