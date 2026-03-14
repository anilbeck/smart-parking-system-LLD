using SmartParkingSystem.Enums;

namespace SmartParkingSystem.Models
{
    public class ParkingFloor
    {
        public int FloorNumber { get; }
        public List<ParkingSpot> Spots { get; }

        public ParkingFloor(int floorNumber, int spotCount)
        {
            FloorNumber = floorNumber;
            Spots = new List<ParkingSpot>();

            for (int i = 1; i <= spotCount; i++)
            {
                Spots.Add(new ParkingSpot(i));
            }
        }

        public int GetAvailableSpots()
        {
            return Spots.Count(s => s.Status == SpotStatus.Available);
        }
    }
}