namespace SmartParkingSystem.Models
{
    public class ParkingLot
    {
        public List<ParkingFloor> Floors { get; }

        public ParkingLot(int floorCount, int spotsPerFloor)
        {
            Floors = new List<ParkingFloor>();

            for (int i = 1; i <= floorCount; i++)
            {
                Floors.Add(new ParkingFloor(i, spotsPerFloor));
            }
        }

        public int GetTotalAvailableSpots()
        {
            return Floors.Sum(f => f.GetAvailableSpots());
        }
    }
}