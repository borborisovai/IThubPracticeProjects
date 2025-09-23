namespace ControlPoint2
{
    public class Insect : Participant
    {
        public string Species { get; set; }
        public double WingSpan { get; set; }
        public override double Run()
        {
            Speed = 5.0 * WingSpan;
            return Speed;
        }
    }
}