namespace ConsoleApp1
{
    public class Adult : Person
    {
        public Adult(string firstName, string lastName) : base(firstName, lastName)
        {
            Random random = new Random();
            Age = random.Next(0, 6);
        }

        public int GoToWork()
        {
            Console.WriteLine(LastName+" is going to work");
            return 1;
        }
    }
}