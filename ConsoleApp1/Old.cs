using System.Media;
namespace ConsoleApp1

{
    public class Old : Person
    {
        public Old(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public int BeingOld()
        {
            Console.WriteLine($"I'm Old!");
            return 1;
        }
    }
}