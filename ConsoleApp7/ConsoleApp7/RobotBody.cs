namespace ConsoleApp7
{
    public partial class Robot
    {
        public void PerformTask(string Task)
        {
            Console.WriteLine($"Robot {Name} is {Task}");
        }
        //public partial void OnTaskStarted();
    }
}