namespace ControlPoint1
{
    public class Building
    {
        private string _address;
        public string Address { get { return _address; } }
        private List<string> _books;
        private string address;

        public Building(string address, List<string> books)
        {
            _address = address;
            _books = books;
        }
    }
}