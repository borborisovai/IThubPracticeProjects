namespace ControlPoint2.Heroes
{
    using ControlPoint2.Interfaces;

    class Bandit : Hero, IPhysicalFighter, IDexterityMaster
    {
        public Bandit(string name)
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

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with a dagger!");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} defends with agility!");
        }

        public void PerformAcrobaticMove()
        {
            Console.WriteLine($"{Name} performs an acrobatic flip!");
        }

        public void EvadeAttack()
        {
            Console.WriteLine($"{Name} evades the incoming attack!");
        }
    }
}