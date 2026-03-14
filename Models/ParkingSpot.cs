using SmartParkingSystem.Enums;
using SmartParkingSystem.Devices;

namespace SmartParkingSystem.Models
{
    public class ParkingSpot
    {
        public int SpotId { get; }
        public SpotStatus Status { get; private set; }
        public Vehicle ParkedVehicle { get; private set; }
        public LightSignal Signal { get; }

        public ParkingSpot(int id)
        {
            SpotId = id;
            Status = SpotStatus.Available;
            Signal = new LightSignal();
        }

        public void Park(Vehicle vehicle)
        {
            if (Status == SpotStatus.Occupied)
                throw new Exception("Spot already occupied");

            ParkedVehicle = vehicle;
            Status = SpotStatus.Occupied;
            Signal.SetRed();
        }

        public void RemoveVehicle()
        {
            ParkedVehicle = null;
            Status = SpotStatus.Available;
            Signal.SetGreen();
        }
    }
}