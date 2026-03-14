namespace SmartParkingSystem.Models
{
    public class Vehicle
    {
        public string LicenseNumber { get; }

        public Vehicle(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
        }
    }
}