namespace ControlPoint1
{
    public class Library : Building
    {
        public List<string> Books;
        public Library(string address, List<string> books) : base(address, books)
        {
            Books = books;
        }

        public bool ValidateBook(string book)
        {
            if (Books.Any(x => x == book))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}