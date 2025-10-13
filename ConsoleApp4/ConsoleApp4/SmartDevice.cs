namespace ConsoleApp4
{
    public abstract class SmartDevice
    {
        public DateTime lastTurnedOn;
        public double totalUptime; // in hours
        public string DeviceName { get; set; }
        public bool IsOn { get; set; }
        public double PowerConsumption { get; set; } // in watts
        public double ConsumedEnergy { get; set; } // in kWh
        public bool IsEnergySavingMode { get; set; }

        public abstract Task Operate();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Device: {DeviceName}, Status: {(IsOn ? "On" : "Off")}");
        }
        public void TurnOff()
        {
            if (!IsOn){Console.WriteLine($"{DeviceName} is already OFF.");return;}
            IsOn = false;
            totalUptime += (DateTime.Now - lastTurnedOn).TotalHours;
            Console.WriteLine($"{DeviceName} is now OFF.");
        }

        public void TurnOn()
        {
            if (IsOn){Console.WriteLine($"{DeviceName} is already ON.");return;}
            IsOn = true;
            lastTurnedOn = DateTime.Now;
            Console.WriteLine($"{DeviceName} is now ON.");
            Operate();
        }
    }
}