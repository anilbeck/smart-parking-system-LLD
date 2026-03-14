using SmartParkingSystem.Models;

namespace SmartParkingSystem.Devices
{
    public class Sensor
    {
        private readonly ParkingSpot _spot;

        public Sensor(ParkingSpot spot)
        {
            _spot = spot;
        }

        public void DetectVehicle(Vehicle vehicle)
        {
            _spot.Park(vehicle);
        }

        public void VehicleLeft()
        {
            _spot.RemoveVehicle();
        }
    }
}