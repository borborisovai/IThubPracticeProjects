namespace ControlPoint2.Heroes
{
    using ControlPoint2.Interfaces;
    public class Warrior : Hero, IPhysicalFighter
    {
        public Warrior(string name)
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
            Console.WriteLine($"{Name} raises a shield to defend!");
        }
    }
}