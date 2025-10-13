namespace ConsoleApp6
{
    public class SafeList<T> : IComparable<T>
    {
        private List<T> items = new List<T>();
        private object lockObject = new object();

        public void Add(T item)
        {
            lock (lockObject)
            {
                if (items.Any(x => EqualityComparer<T>.Default.Equals(x, item)))
                {
                    Console.WriteLine($"Item '{item}' already exists. Skipping addition.");
                    return; // Prevent adding duplicates   
                }
                items.Add(item);
                Console.WriteLine($"Adding '{item}'");
            }
        }

        public bool Remove(T item)
        {
            lock (lockObject)
            {
                Console.WriteLine($"Removing '{item}'");
                return items.Remove(item);
            }
        }

        public T GetMin()
        {
            lock (lockObject)
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("The list is empty.");

                return items.Min();
            }
        }

        public T GetMax()
        {
            lock (lockObject)
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("The list is empty.");

                return items.Max();
            }
        }

        public int CompareTo(T? other)
        {
            foreach (var item in items)
            {
                if (item is IComparable<T> comparableItem)
                {
                    int comparison = comparableItem.CompareTo(other);
                    if (comparison != 0)
                        return comparison;
                }
            }
            return 0;
        }

        public int Count
        {
            get
            {
                lock (lockObject)
                {
                    return items.Count;
                }
            }
        }
    }
}