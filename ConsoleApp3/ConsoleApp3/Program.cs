// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
Console.WriteLine("Hello, World!");
List<Vehicle> vehicles = new List<Vehicle>();
Console.WriteLine("Введите комманду (используйте 'help' для отображения списка всех команд):");
for (; 1 > 0;)
{
    Console.Write("> ");
    string line = Console.ReadLine();
    string command = line.Split(' ')[0].ToLower();
    string[] argu = line.Split(' ').Skip(1).ToArray();
    try
    {
    switch (command)
    {
        case "CreateCar":
            CreateCar(argu[0]);
            break;
        case "CreateBicycle":
            CreateBicycle(argu[0]);
            break;
        case "CreateElectricScooter":
            CreateElectricScooter(argu[0]);
            break;
        case "Move":
            if (argu.Length > 0)
            {
                var vehicle = vehicles.FirstOrDefault(v => v.Name == argu[0]);
                if (vehicle != null)
                {
                    vehicle.Move();
                }
                else
                {
                    Console.WriteLine($"Нет машин под названием {argu[0]}");
                }
                break;
            }
            foreach (var vehicle in vehicles)
                {
                    vehicle.Move();
                }
            break;
        case "help":
            Console.WriteLine("Доступные комманды:\nCreateCar [name]\nCreateBicycle [name]\nCreateElectricScooter [name]\nMove (name)\nhelp\nexit");
            break;
        case "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Неизвестная комманда. Используйте 'help' для отображения списка всех команд.");
            break;
    }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

}

void CreateElectricScooter(string name)
{
    CreateVehicle("ElectricScooter", name);
}

void CreateBicycle(string name)
{
    CreateVehicle("Bicycle", name);
}

void CreateCar(string name)
{
     CreateVehicle("Car", name);
}
void CreateVehicle(string type, string name)
{
    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Ошибка: имя не может быть пустым.");
        return;
    }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    Vehicle vehicle = type switch
    {
        "Car" => new Car(name),
        "Bicycle" => new Bicycle(name),
        "ElectricScooter" => new ElectricScooter(name),
        _ => null
    };
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

    if (vehicle != null)
    {
        vehicles.Add(vehicle);
        vehicle.PrintInfo();
    }
    else
    {
        Console.WriteLine($"Ошибка: неизвестный тип транспортного средства '{type}'.");
    }
}