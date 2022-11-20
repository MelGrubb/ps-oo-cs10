# 03 - The Four Pillars

Example diagrams for module 3 - The Four Pillars

## Class Diagram

```mermaid
classDiagram
	class EC1 {
	}
	EC1 --|> Car : inherits

	class S1 {
	}
	S1 --|> Car : inherits

	class Car {
		<<abstract>>
		+BrakePedal : BrakePedal
		+EngineControlModule : EngineControlModule
		+IsRunning : bool
		+Make : string
		+Model : string
		+SteeringWheel : SteeringWheel
		+Throttle : Throttle
		+Start()
		+Stop()
	}
	Car --> BrakePedal
	Car --> EngineControlModule
	Car --> SteeringWheel
	Car --> Throttle

	class ElectricControlModule {
	}
	ElectricControlModule --|> EngineControlModule : inherits

	class IceControlModule {
		-_crankPositionSensor : CrankPositionSensor
		-_exhaustOxygenSensor : ExhaustOxygenSensor
	}
	IceControlModule --|> EngineControlModule : inherits
	IceControlModule --> CrankPositionSensor
	IceControlModule --> ExhaustOxygenSensor

	class EngineControlModule {
		<<abstract>>
		#AirTemperatureSensor : AirTemperatureSensor
		#ThrottlePositionSensor : ThrottlePositionSensor
		#Status : int
		+IsRunning : bool
		+Start()
		+Stop()
	}
	EngineControlModule --> ThrottlePositionSensor
```
