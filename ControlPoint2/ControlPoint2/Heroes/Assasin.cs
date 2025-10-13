namespace ControlPoint2.Heroes
{
    using System.Collections;
    using ControlPoint2.Interfaces;
    class Assasin : Hero, IDexterityMaster
    {
        public Assasin(string name)
        {
            Name = name;
            Level = 1;
        }

        public override void UseAbility(string ability)
        {
            switch (ability.ToLower())
            {
                case "evade":
                    EvadeAttack();
                    break;
                case "acrobatic":
                    PerformAcrobaticMove();
                    break;
                default:
                    Console.WriteLine($"{Name} doesn't know this ability.");
                    break;
            }
        }

        public void PerformAcrobaticMove()
        {
            Console.WriteLine($"{Name} performs an acrobatic move!");
        }

        public void EvadeAttack()
        {
            Console.WriteLine($"{Name} evades the incoming attack!");
        }
    }
}