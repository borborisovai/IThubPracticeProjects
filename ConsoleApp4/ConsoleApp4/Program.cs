// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

Console.WriteLine("Hello, World!");
List<SmartDevice> devices = new List<SmartDevice>();
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
            case "device":
                switch (argu[0].ToLower())
                {
                    case "add":
                        DeviceAdd(argu);
                        break;
                    case "list":
                        DeviceList();
                        break;
                    case "remove":
                        DeviceRemove(argu);
                        break;
                    case "start":
                        DeviceStart(argu);
                        break;
                    case "stop":
                        DeviceStop(argu);
                        break;
                    case "status":
                        DeviceStatus(argu);
                        break;
                    case "help":
                        Console.WriteLine("Доступные подкомманды для Device:\nadd (type) (name)\nlist\nremove (name)\nstart (name)\nstop (name)\nstatus (name)\nhelp");
                        break;
                    default:
                        Console.WriteLine("Неизвестная подкомманда для Device. Используйте 'Device help'.");
                        break;
                }
                break;
            case "help":
                Console.WriteLine("Доступные комманды:\nDevice [add/list/remove/start/stop/status/help]\nhelp\nexit");
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

void DeviceStatus(string[] argu)
{
    if (argu.Length < 2) { Console.WriteLine("Недостаточно аргументов. Используйте: Device status (name)"); return; }
    var deviceToStatus = devices.FirstOrDefault(d => d.DeviceName.Equals(argu[1], StringComparison.OrdinalIgnoreCase));
    if (deviceToStatus == null) { Console.WriteLine($"Устройство с именем '{argu[1]}' не найдено."); return; }
    if (deviceToStatus is IMonitoring monitorableDevice)
    {
        monitorableDevice.PrintStatusReport();
    }
    else
    { Console.WriteLine($"Устройство '{argu[1]}' не поддерживает мониторинг."); }
}

void DeviceStop(string[] argu)
{
    if (argu.Length < 2) { Console.WriteLine("Недостаточно аргументов. Используйте: Device stop (name)"); return; }
    var deviceToStop = devices.FirstOrDefault(d => d.DeviceName.Equals(argu[1], StringComparison.OrdinalIgnoreCase));
    if (deviceToStop == null) { Console.WriteLine($"Устройство с именем '{argu[1]}' не найдено."); return; }
    deviceToStop.TurnOff();
}

void DeviceStart(string[] argu)
{
    if (argu.Length < 2) { Console.WriteLine("Недостаточно аргументов. Используйте: Device start (name)"); return; }
    var deviceToStart = devices.FirstOrDefault(d => d.DeviceName.Equals(argu[1], StringComparison.OrdinalIgnoreCase));
    if (deviceToStart == null) { Console.WriteLine($"Устройство с именем '{argu[1]}' не найдено."); return; }
    deviceToStart.TurnOn();
}

void DeviceRemove(string[] argu)
{
    if (argu.Length < 2) { Console.WriteLine("Недостаточно аргументов. Используйте: Device remove (name)"); return; }
    string nameToRemove = argu[1];
    var deviceToRemove = devices.FirstOrDefault(d => d.DeviceName.Equals(nameToRemove, StringComparison.OrdinalIgnoreCase));
    if (deviceToRemove == null) { Console.WriteLine($"Устройство с именем '{nameToRemove}' не найдено."); return; }
    devices.Remove(deviceToRemove);
    Console.WriteLine($"Устройство '{nameToRemove}' удалено.");
}

void DeviceList()
{
    if (devices.Count == 0) { Console.WriteLine("Нет добавленных устройств."); return; }
    Console.WriteLine("Список устройств:");
    foreach (var device in devices)
    { device.PrintInfo(); }
}

void DeviceAdd(string[] argu)
{
    if (argu.Length < 3) { Console.WriteLine("Недостаточно аргументов. Используйте: Device add (type) (name)"); return; }
    string type = argu[1].ToLower();
    string name = argu[2];
    if (devices.Any(d => d.DeviceName.Equals(name, StringComparison.OrdinalIgnoreCase)))
    { Console.WriteLine($"Устройство с именем '{name}' уже существует."); return; }
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    SmartDevice newDevice = type switch
    {
        "smartlight" => new SmartLight(name),
        "smartthermostat" => new SmartThermostat(name),
        "smartsecuritycamera" => new SmartSecurityCamera(name),
        "smartcatfeeder" => new SmartCatFeeder(name),
        // Add other device types here as needed
        _ => null
    };
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    if (newDevice == null) { Console.WriteLine($"Неизвестный тип устройства: {type}"); return; }
    devices.Add(newDevice);
    Console.WriteLine($"Устройство '{name}' типа '{type}' добавлено.");
}