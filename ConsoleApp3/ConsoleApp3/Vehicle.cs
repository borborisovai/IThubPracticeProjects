namespace ConsoleApp3
{
    public abstract class Vehicle
    {
        public string _name;
        public string Name { get { return _name; } }
        public double MaxSpeed { get; set; }
        public double FuelLevel = 100.0;
        public Vehicle(string name) { _name = name; }
        public abstract void Move();
        public virtual Vehicle GetInfo()
        {
            return this;
        }
        public virtual void PrintInfo()
        {
            Vehicle a = GetInfo();

            Console.WriteLine(
                "\n======[CAR INFO]======" +
                "\nNAME: " + a.Name +
                "\nMAX SPEED: " + a.MaxSpeed +
                "\n======================"
                );
        }
    }
}