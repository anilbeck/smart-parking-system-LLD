
# SystemDesign.md

## Problem Statement
Design a Smart Parking System with multiple floors where each parking spot has a sensor and a light indicator.
Green indicates availability, Red indicates occupancy. The entrance board shows total available spaces.

## Functional Requirements
- Support multiple parking floors
- Each spot detects vehicle presence
- Light indicators update in real time
- Entrance display shows available spaces
- Support concurrent parking operations

## Non Functional Requirements
- Low latency updates
- High availability
- Fault tolerance
- Scalable to thousands of parking spots

## Core Entities

ParkingLot
ParkingFloor
ParkingSpot
Vehicle
Sensor
DisplayBoard
ParkingManager

## API Design

GET /parking/available

Response:
{
  "availableSpots": 120
}

POST /parking/update

Body:
{
  "spotId": 21,
  "status": "Occupied"
}

## Database Schema

ParkingSpot
| SpotId | Floor | Status |

ParkingEvent
| EventId | SpotId | Timestamp | EventType |

## Concurrency Handling
Use locking or atomic counters when updating spot status to avoid race conditions.

## Scaling Strategy
- Use Redis to store available spot counters
- Kafka for sensor event streaming
- Microservices architecture for multiple parking locations

## Future Enhancements
- Mobile application for drivers
- Navigation to nearest available parking
- Reservation system
- AI based parking optimization
