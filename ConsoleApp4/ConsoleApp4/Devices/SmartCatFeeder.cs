namespace ConsoleApp4
{
    public class SmartCatFeeder : SmartDevice, IPowerControl, IMonitoring
    {
        DateTime lastFedTime;
        public double FoodDispensed { get; set; } // in grams
        public SmartCatFeeder(string name)
        {
            DeviceName = name;
            PowerConsumption = 0.1; // 100 watts
            IsOn = false;
            totalUptime = 0;
            lastFedTime = DateTime.MinValue;
        }

        public void DisableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.1; // Restore power consumption to 100 watts
            Console.WriteLine($"{DeviceName} no longer in Energy Saving Mode.");
        }

        public void EnableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.05; // Reduce power consumption to 50 watts
            Console.WriteLine($"{DeviceName} is now in Energy Saving Mode.");
        }

        public double GetCurrentPowerUsage()
        {
            return IsOn ? PowerConsumption : 0;
        }

        public double GetUptime()
        {
            return totalUptime;
        }

        public override async Task Operate()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{DeviceName} is off. Please turn it on to operate.");
                throw new InvalidOperationException("Device is off");
            }
            for (; 0 < 3;)
            {
                if (!IsOn) break;
                await Task.Delay(60000); // Simulate some operation delay
                totalUptime += 1.0 / 60; // Increment uptime by 1 minute
                ConsumedEnergy += PowerConsumption / 1000 / 60;
                
                if ((DateTime.Now - lastFedTime).TotalHours >= 6) // Feed every 6 hours
                {
                    FoodDispensed += 50; // Dispense 50 grams of food
                    lastFedTime = DateTime.Now;
                    Console.WriteLine($"{DeviceName} dispensed 50 grams of food.");
                }
            }
            
        }

        public void PrintStatusReport()
        {
            Console.WriteLine(
                $"\nStatus Report for {DeviceName}:" +
                $"\n- Power Status: {(IsOn ? "On" : "Off")}" +
                $"\n- Food Dispensed: {FoodDispensed}g" +
                $"\n- Last Fed Time: {(lastFedTime == DateTime.MinValue ? "Never" : lastFedTime.ToString())}" +
                $"\n- Current Power Usage: {GetCurrentPowerUsage()}W" +
                $"\n- Total Uptime: {GetUptime():F2} hours" +
                $"\n- Consumed Energy: {ConsumedEnergy:F4} kWh" +
                $"\n- Energy Saving Mode: {(IsEnergySavingMode ? "Enabled" : "Disabled")}");
        }
    }
}