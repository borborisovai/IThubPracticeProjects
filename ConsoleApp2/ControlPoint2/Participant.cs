namespace ControlPoint2
{
    public class Participant
    {
        public double Speed { get; set; }
        public double Time { get; set; }
        public double Distance { get; set; }
        public double Stamina { get; set; }
        public virtual double   Run()
        {
            return Speed;
        }
        public virtual double Run(double distance)
        {
            return (double)distance / Speed;
        }
        public virtual double Run(int distance, double Stamina)
        {
            return (double)distance / (Speed * Stamina);
        }
    }
}