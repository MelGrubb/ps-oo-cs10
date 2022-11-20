# 03 - The Four Pillars

Example diagrams for module 3 - The Four Pillars

## Class Diagram

```mermaid
classDiagram
	class Car {
		+BrakePedal : BrakePedal
		+EngineControlModule : EngineControlModule
		+Make : string
		+Model : string
		+SteeringWheel : SteeringWheel
		+Throttle : Throttle
		+Start() bool
		+Stop() bool
	}
	Car --> BrakePedal
	Car --> EngineControlModule
	Car --> SteeringWheel
	Car --> Throttle
	class EngineControlModule {
		-_crankPositionSensor : CrankPositionSensor:
		-_throttlePositionSensor : ThrottlePositionSensor
		+Start() bool
		+Stop() bool
	}
	EngineControlModule --> CrankPositionSensor
	EngineControlModule --> ThrottlePositionSensor
```