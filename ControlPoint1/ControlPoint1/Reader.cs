namespace ControlPoint1
{
    public class Reader : Person
    {
        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void ReadBook(Library library, string book)
        {
            if (library.ValidateBook(book))
            {
                Console.WriteLine($"{FirstName} {LastName} читает книгу {book}");
            }
            else
            {
                Console.WriteLine("Данной книги не существует");
            }
        }
    }
}