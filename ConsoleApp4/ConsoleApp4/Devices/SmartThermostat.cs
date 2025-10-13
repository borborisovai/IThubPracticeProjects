namespace ConsoleApp4
{
    public class SmartThermostat : SmartDevice, IPowerControl, IMonitoring
    {
        public double Themperature { get; set; } // in Celsius
        public SmartThermostat(string name)
        {
            DeviceName = name;
            PowerConsumption = 0.01; // 10 watts
            IsOn = false;
            totalUptime = 0;
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
                $"\n- Current Temperature: {Themperature}°C" +
                $"\n- Current Power Usage: {GetCurrentPowerUsage()}W" +
                $"\n- Total Uptime: {GetUptime():F2} hours" +
                $"\n- Consumed Energy: {ConsumedEnergy:F4} kWh" +
                $"\n- Energy Saving Mode: {(IsEnergySavingMode ? "Enabled" : "Disabled")}");
        }
    }
}