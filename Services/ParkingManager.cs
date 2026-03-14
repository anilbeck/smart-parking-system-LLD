using SmartParkingSystem.Models;
using SmartParkingSystem.Devices;

namespace SmartParkingSystem.Services
{
    public class ParkingManager
    {
        private readonly ParkingLot _parkingLot;
        private readonly DisplayBoard _displayBoard;
        private readonly object _lock = new object();

        public ParkingManager(ParkingLot parkingLot, DisplayBoard displayBoard)
        {
            _parkingLot = parkingLot;
            _displayBoard = displayBoard;
        }

        public void ParkVehicle(int floor, int spotId, Vehicle vehicle)
        {
            lock (_lock)
            {
                var spot = _parkingLot.Floors[floor - 1].Spots[spotId - 1];
                spot.Park(vehicle);
                UpdateDisplay();
            }
        }

        public void RemoveVehicle(int floor, int spotId)
        {
            lock (_lock)
            {
                var spot = _parkingLot.Floors[floor - 1].Spots[spotId - 1];
                spot.RemoveVehicle();
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            int available = _parkingLot.GetTotalAvailableSpots();
            _displayBoard.ShowAvailableSpots(available);
        }
    }
}