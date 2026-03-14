using SmartParkingSystem.Enums;

namespace SmartParkingSystem.Devices
{
    public class LightSignal
    {
        public LightColor Color { get; private set; }

        public LightSignal()
        {
            Color = LightColor.Green;
        }

        public void SetGreen()
        {
            Color = LightColor.Green;
        }

        public void SetRed()
        {
            Color = LightColor.Red;
        }
    }
}