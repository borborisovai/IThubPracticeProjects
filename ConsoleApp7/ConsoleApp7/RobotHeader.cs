namespace ConsoleApp7
{
    public partial class Robot
    {
        public string Model;
        public string Name;
        public Robot(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n====[INFO]====" +
            "\nName: " + Name +
            "\nModel: " + Model);
        }
    }
}