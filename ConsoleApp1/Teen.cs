using System.Diagnostics.Contracts;

namespace ConsoleApp1
{
    public class Teen : Person
    {
        public int Grade { get; set; }
        public Teen(string firstName, string lastName) : base(firstName, lastName)
        {
            Random random = new Random();
            Age = random.Next(7, 17);

            Grade = Age - 7 + random.Next(0, 1);
            if (Grade == 0) { Grade = 1; }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("I am teenager");
        }
        public int Study()
        {
            if (Age < 12)
            {
                Console.WriteLine(FirstName + " studing with joy");
                return 1;
            }
            else
            {
                Console.WriteLine(FirstName + " don't wanna do it");
                return 0;
            }
        }
    }
}