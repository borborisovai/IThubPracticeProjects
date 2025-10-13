namespace ConsoleApp3
{
    public class Car : Vehicle, IRefuable, IMAINTenable
    {
        Random random = new Random();
        public Car(string name) : base(name)
        {
            MaxSpeed = random.Next(60, 120);

        }

        public override void Move()
        {
            if (FuelLevel == 0)
            {
                Console.WriteLine($"* Машина {Name} не может поехать, так как у нее нет топлива! Пожалуйста заправьте ее.");
                return;
            }
            int distance = random.Next(10, 50);
            FuelLevel = FuelLevel - distance * 0.5;
            if (FuelLevel < 0){ FuelLevel = 0; }
            if (FuelLevel == 0)
            { Console.WriteLine($"* Машина {Name} заглохла из-за отсутствия топлива! Оставшееся растояние она проехала на инерции :P"); }
            Console.WriteLine($"* Машина {Name} проехала {distance} км");
            Console.WriteLine($"* Количество топлива в {Name} терерь: {FuelLevel} литров");
        }

        public void PerformMaintenance()
        {
            throw new NotImplementedException();
        }

        public void Refuel(double amount)
        {
            FuelLevel = FuelLevel + amount;
            if (FuelLevel > 100.0)
            {
                FuelLevel = 100.0;
                Console.WriteLine("* Вы налили слишком много топлива. Часть вылелась на землю\nПосмотри что ты наделал!");
            }
            Console.WriteLine($"* Количество топлива в {Name} терерь: {FuelLevel} литров");
        }
    }
}