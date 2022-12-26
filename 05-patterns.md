# 05 - Design Patterns

Example diagrams for module 5 - Design Patterns

## Singleton

```mermaid
classDiagram
	class Singleton {
		-instance$ : Singleton
		+Instance$ : Singleton
		-Singleton()
	}
```

## Builder

```mermaid
classDiagram
	class Client {
		+Construct()
	}
	Client --> Builder : uses

	class Builder {
		<<abstract>>
		+Build()
	}

	class ConcreteBuilder {
		+BuildPart()
		+GetResult()
	}
	ConcreteBuilder --|> Builder : inherits
```
