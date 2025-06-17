namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem smartHome = new SmartHomeSystem();

            smartHome.DeviceStateChanged += OnDeviceStateChanged;

            smartHome.TurnOnLight();
            smartHome.SetTemperature(23);
            smartHome.LockDoor();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void OnDeviceStateChanged(object sender, EventArgs e)
        {
            var args = (DeviceEventArgs)e;
            
            Console.WriteLine($"[{args.ChangeTime.ToLocalTime():HH:mm:ss}] {args.DeviceType}: {args.NewState}");
        }
    }

    public class DeviceEventArgs : EventArgs
    {
        public string DeviceType { get; set; }
        public string NewState { get; set; }
        public DateTime ChangeTime { get; set; }

        public DeviceEventArgs(string deviceType, string newState)
        {
            DeviceType = deviceType;
            NewState = newState;
            ChangeTime = DateTime.UtcNow;
        }
    }

    public class SmartHomeSystem
    {
        public event EventHandler<DeviceEventArgs> DeviceStateChanged;

        public void TurnOnLight()
        {
            TriggerDeviceChange("Light", "Включен");
        }

        public void TurnOffLight()
        {
            TriggerDeviceChange("Light", "Выключен");
        }

        public void SetTemperature(int temperature)
        {
            TriggerDeviceChange("Thermostat", $"Температура изменена на {temperature}°C");
        }

        public void LockDoor()
        {
            TriggerDeviceChange("Door", "Заблокирована");
        }

        public void UnlockDoor()
        {
            TriggerDeviceChange("Door", "Разблокирована");
        }

        private void TriggerDeviceChange(string deviceType, string state)
        {
            var args = new DeviceEventArgs(deviceType, state);

            DeviceStateChanged?.Invoke(this, args);
        }
    }
}
