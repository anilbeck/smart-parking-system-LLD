using SmartParkingSystem.Models;
using SmartParkingSystem.Services;
using SmartParkingSystem.Devices;

class Program
{
    static void Main()
    {
        ParkingLot lot = new ParkingLot(3, 10);
        DisplayBoard board = new DisplayBoard();
        ParkingManager manager = new ParkingManager(lot, board);

        Vehicle car1 = new Vehicle("KA01AB1234");

        manager.ParkVehicle(1, 1, car1);
        manager.RemoveVehicle(1, 1);
    }
}