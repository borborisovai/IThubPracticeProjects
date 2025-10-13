namespace ConsoleApp4
{
    public interface IMonitoring
    {
        double GetCurrentPowerUsage(); // in watts
        double GetUptime(); // in hours
        void PrintStatusReport();
    }
}