namespace ControlPoint2
{
    public class Animal : Participant
    {
        public string Species { get; set; }
        public override double Run()
        {
            switch (Species)
            {
                case AnimalType.Dog:
                    Speed = 20.0;
                    break;
                case AnimalType.Cat:
                    Speed = 15.0;
                    break;
                case AnimalType.Horse:
                    Speed = 25.0;
                    break;
                case AnimalType.Rabbit:
                    Speed = 18.0;
                    break;
                default:
                    Speed = 10.0;
                    break;
            }
            return Speed;
        }
    }
    public class AnimalType
    {
        public const string Dog = "Dog";
        public const string Cat = "Cat";
        public const string Horse = "Horse";
        public const string Rabbit = "Rabbit";

    }
}