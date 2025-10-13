namespace ConsoleApp3
{
    public class Bicycle : Vehicle, IMAINTenable
    {
        public Bicycle(string name) : base(name)
        {
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public void PerformMaintenance()
        {
            throw new NotImplementedException();
        }
    }
}