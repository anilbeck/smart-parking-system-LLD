
# Architecture.md

## Smart Parking System Architecture

### Overview
The Smart Parking System manages parking across multiple floors and spots using sensors and light indicators.
Each parking spot reports availability using a sensor. A central service aggregates data and updates the entrance display.

### High Level Architecture

Parking Sensors → Floor Controller → Parking Service → Cache / Database → Display Board

### Components

1. Parking Sensor
- Detects whether a vehicle is present
- Sends updates to the Floor Controller

2. Floor Controller
- Collects sensor updates for a specific floor
- Sends aggregated status updates to the Parking Service

3. Parking Service
- Central system managing all floors
- Calculates available spots
- Sends updates to display boards

4. Cache Layer (Optional)
- Stores real-time count of available spots
- Example: Redis

5. Database
- Stores parking history and spot metadata

6. Entrance Display Board
- Displays total available parking spots

### Data Flow

1. Vehicle parks in spot
2. Sensor detects vehicle
3. Floor controller updates spot status
4. Parking service updates availability
5. Display board shows updated available spaces

### Scalability Considerations

- Redis for real-time counters
- Message queue for sensor events
- Horizontal scaling for Parking Service
- IoT gateway for sensor communication

### Fault Tolerance

- Sensor heartbeat monitoring
- Event retries using queue systems
- Backup display boards
