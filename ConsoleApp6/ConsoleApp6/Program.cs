using ConsoleApp6;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("====String Test====");
SafeList<string> safeList = new SafeList<string>();
safeList.Add("apple");
safeList.Add("banana");
safeList.Add("cherry");
Console.WriteLine($"Min: {safeList.GetMin()}");
Console.WriteLine($"Max: {safeList.GetMax()}");
Console.WriteLine($"Count: {safeList.Count}");
safeList.Remove("banana");
Console.WriteLine($"Count after removal: {safeList.Count}");
Console.WriteLine($"Comparison with 'apple': {safeList.CompareTo("apple")}");
Console.WriteLine($"Comparison with 'date': {safeList.CompareTo("date")}");
safeList.Add("apple"); // Adding duplicate to test behavior
Console.WriteLine($"Count after adding duplicate: {safeList.Count}");

Console.WriteLine("\n====Int Test====");
SafeList<int> intList = new SafeList<int>();
intList.Add(10);
intList.Add(20);
intList.Add(5);
Console.WriteLine($"Min: {intList.GetMin()}");
Console.WriteLine($"Max: {intList.GetMax()}");
Console.WriteLine($"Count: {intList.Count}");
intList.Remove(20);
Console.WriteLine($"Count after removal: {intList.Count}");
Console.WriteLine($"Comparison with 10: {intList.CompareTo(10)}");
Console.WriteLine($"Comparison with 15: {intList.CompareTo(15)}");
intList.Add(5); // Adding duplicate to test behavior
Console.WriteLine($"Count after adding duplicate: {intList.Count}");
