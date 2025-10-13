namespace ConsoleApp4
{
    public class SmartLight : SmartDevice, IPowerControl, IEnergySaver, IMonitoring
    {
        public double BrightnessLevel { get; set; } // 0 to 100
        public SmartLight(string name)
        {
            DeviceName = name;
            PowerConsumption = 0.1; // 100 watts
            IsOn = false;
            totalUptime = 0;
        }

        public void DisableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.1; // Restore power consumption to 100 watts
            Console.WriteLine($"{DeviceName} no longer in Energy Saving Mode.");
            BrightnessLevel = 100;
        }

        public void EnableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.05; // Reduce power consumption to 50 watts
            Console.WriteLine($"{DeviceName} is now in Energy Saving Mode.");
            BrightnessLevel = 50; // Dim the light
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
                await Task.Delay(60000); // Simulate some operation delay
                totalUptime += 1.0 / 60; // Increment uptime by 1 minute
                ConsumedEnergy += PowerConsumption / 1000 / 60;
                if (!IsOn) break;
            }
            
        }

        public void PrintStatusReport()
        {
            Console.WriteLine(
                $"\nStatus Report for {DeviceName}:" +
                $"\n- Power Status: {(IsOn ? "On" : "Off")}" +
                $"\n- Brightness Level: {BrightnessLevel}%" +
                $"\n- Current Power Usage: {GetCurrentPowerUsage()}W" +
                $"\n- Total Uptime: {GetUptime():F2} hours" +
                $"\n- Consumed Energy: {ConsumedEnergy:F4} kWh" +
                $"\n- Energy Saving Mode: {(IsEnergySavingMode ? "Enabled" : "Disabled")}");
        }
    }
}