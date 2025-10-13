namespace ConsoleApp3
{
    public class ElectricScooter : Vehicle, IRefuable, IMAINTenable
    {
        public ElectricScooter(string name) : base(name)
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

        public void Refuel(double amount)
        {
            throw new NotImplementedException();
        }
    }
}