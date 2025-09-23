namespace ConsoleApp1
{
    public class Robot
    {
        public string Name { get; set; }
        public string Model { get;set; }
        public ulong SerialNumber { get; set; }
        public string Type { get; set; }

        public Robot(string name, string type, string model, ulong serialNumber)
        {
            Name = name;
            Type = type;
            Model = model;
            SerialNumber = serialNumber;
        }
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, I am a {Type}\nMy model is {Model}. Serial number: {SerialNumber.ToString()}");
        }
        

    }
}