namespace ControlPoint1
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName)
        {
            Random random = new Random();
            FirstName = firstName;
            LastName = lastName;
            Age = random.Next(0, 100);
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