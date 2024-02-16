# 04 - The SOLID Principles

Example diagrams for module 4 - The SOLID Principles

## Class Diagram

```mermaid
classDiagram
	class IStartable {
		<<interface>>
		+Start() void
		+Stop() void
	}

	class Car {
		+Make : string
		+Model : string
		+EngineControlModule : EngineControlModule
		+IsRunning : bool
		+BrakePedal : BrakePedal
		+SteeringWheel : SteeringWheel
		+Throttle : Throttle
		+Start() void
		+Stop() void
	}
	Car --|> IStartable : implements
	Car --> EngineControlModule

	class EngineControlModule {
		<<abstract>>
		+EngineType : EngineType
		+AirTemperatureSensor : AirTemperatureSensor
		+CrankPositionSensor : CrankPositionSensor
		+ExhaustOxygenSensor : ExhaustOxygenSensor
		+ThrottlePositionSensor : ThrottlePositionSensor
		+IsRunning : bool
		+Start() void
		+Stop() void
	}
	EngineControlModule --> EngineType

	class ElectricControlModule {
		<<sealed>>
		-_relayStatus : int
	}
	ElectricControlModule --|> EngineControlModule

	class HybridControlModule {
		<<sealed>>
		-_engineStatus : int
		-_relayStatus : int
	}
	HybridControlModule --|> EngineControlModule

	class IceControlModule {
		<<sealed>>
		-_engineStatus : int
	}
	IceControlModule --|> EngineControlModule

	class EngineType {
		<<enumeration>>
		Gasoline = 1
		Electric = 2
		Hybrid = 3
	}
```
