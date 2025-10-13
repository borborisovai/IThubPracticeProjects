using System.Diagnostics;

namespace ConsoleApp4
{
    public class SmartSecurityCamera : SmartDevice, IPowerControl, IEnergySaver, IMonitoring
    {
        public int FPS { get; set; } // Frames per second
        public double InfroredSensitivity { get; set; } // Sensitivity level for night vision
        public bool MotionDetection { get; set; } // Motion detection status
        public bool NightVision { get; set; } // Night vision status
        public double BrightnessLevel { get; set; }  // 0 to 100

        public SmartSecurityCamera(string name)
        {
            DeviceName = name;
            PowerConsumption = 0.1; // 100 watts
            InfroredSensitivity = 50; // Default sensitivity
            MotionDetection = false;
            NightVision = false;
            BrightnessLevel = 100;
            IsOn = false;
            totalUptime = 0;
            FPS = 30; // Default FPS
        }

        public void DisableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.1; // Restore power consumption to 100 watts
            Console.WriteLine($"{DeviceName} no longer in Energy Saving Mode.");
            FPS = 30; // Restore FPS
        }

        public void EnableEnergySavingMode()
        {
            IsEnergySavingMode = true;
            PowerConsumption = 0.05; // Reduce power consumption to 50 watts
            Console.WriteLine($"{DeviceName} is now in Energy Saving Mode.");
            FPS = 10; // Reduce FPS
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
            Random random = new Random();
            for (; 0 < 3;)
            {
                if (!IsOn) break;
                await Task.Delay(60000); // Simulate some operation delay
                totalUptime += 1.0 / 60; // Increment uptime by 1 minute
                ConsumedEnergy += PowerConsumption / 1000 / 60;
                BrightnessLevel = random.Next(0, 100); // Simulate brightness level change
                BrightnessLevelChanged();
                
            }
            
        }
        public double BrightnessLevelChanged()
        {
            if (BrightnessLevel > InfroredSensitivity)
            {
                NightVision = false;
            }
            else
            {
                NightVision = true;
            }
            return BrightnessLevel;
        }

        public void PrintStatusReport()
        {
            Console.WriteLine(
                $"\nStatus Report for {DeviceName}:" +
                $"\n- Power Status: {(IsOn ? "On" : "Off")}" +
                $"\n- FPS: {FPS}fps" +
                $"\n- Brightness Level: {BrightnessLevel}%" +
                $"\n- Infrared Sensitivity: {InfroredSensitivity}%" +
                $"\n- Motion Detection: {(MotionDetection ? "Enabled" : "Disabled")}" +
                $"\n- Night Vision: {(NightVision ? "Enabled" : "Disabled")}" +
                $"\n- Current Power Usage: {GetCurrentPowerUsage()}W" +
                $"\n- Total Uptime: {GetUptime():F2} hours" +
                $"\n- Consumed Energy: {ConsumedEnergy:F4} kWh" +
                $"\n- Energy Saving Mode: {(IsEnergySavingMode ? "Enabled" : "Disabled")}");
        }
    }
}