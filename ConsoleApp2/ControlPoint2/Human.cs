namespace ControlPoint2
{
    public class Human : Participant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override double Run()
        {
            Speed = 10.0 / (0.05 * Age);
            return Speed;
        }
    }
}