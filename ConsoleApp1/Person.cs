namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void ShowInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("My first name is " + FirstName);
            Console.WriteLine("My last name is " + LastName);
            Console.WriteLine("My age is "+Age);
        }
     }
}