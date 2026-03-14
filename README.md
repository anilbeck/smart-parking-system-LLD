# Smart Parking System (LLD - C#)

This project demonstrates a Low Level Design (LLD) of a Smart Parking System commonly asked in system design interviews.

## Features
- 3 Floor Parking Lot
- Sensor-based parking detection
- Light indicators (Green = Available, Red = Occupied)
- Entrance display showing total available spaces
- Thread-safe parking operations
- Clean object-oriented design

## Project Structure

SmartParkingSystem
│
├── Models
│   ├── ParkingLot.cs
│   ├── ParkingFloor.cs
│   ├── ParkingSpot.cs
│   ├── Vehicle.cs
│
├── Devices
│   ├── Sensor.cs
│   ├── LightSignal.cs
│   ├── DisplayBoard.cs
│
├── Services
│   ├── ParkingManager.cs
│
├── Enums
│   ├── SpotStatus.cs
│   ├── LightColor.cs
│
└── Program.cs

## How it Works

1. Vehicle arrives and sensor detects the vehicle.
2. Parking spot status changes to Occupied.
3. Light signal turns RED.
4. ParkingManager updates the system.
5. Entrance DisplayBoard updates available spots.

## Future Improvements

- REST API using ASP.NET Core
- Redis caching for real-time counters
- Database integration (SQL Server/PostgreSQL)
- Kafka event streaming
- Mobile application integration