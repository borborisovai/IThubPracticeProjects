namespace ConsoleApp1
{
    public class Child : Person
    {
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
            Random random = new Random();
            Age = random.Next(0, 6);

        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Ugu gaga");
        }
        public int PlayWithToys()
        {
            Console.WriteLine(FirstName+" are playing with toys");
            return 1;
        }
    }
}