# 02 - Introduction to Object-oriented Design

## Mermaid

A quick demo of using Mermaid to embed diagrams in markdown documents.

### Flowcharts

```mermaid
graph TB
  A[Start] -.-> B(Process 1)
  A --> C[[Process 2]]
  B ==o D([Stop])
  C --> D
```

---

### Class Diagrams

```mermaid
classDiagram
  class IValidatableObject {
    <<interface>>
    Validate() IEnumerable~ValidationResult~
  }
  class Address {
    +Id : Guid
    +Address1 : string
    +Address2 : string
    +City : string
    +State : string
    +ZipCode : string
  }
  class Person {
    +Id : Guid
    +FirstName : string
    +LastName : string
    +FullName : string
    +EmailAddress : string
    +List~Address~ Addresses
    +PhoneNumber : string
    +Validate() IEnumerable~ValidationResult~
  }
  Person ..|> IValidatableObject : Implements
  Person "1" --> "*" Address
```

---

### Coupling

```mermaid
classDiagram
  class ILogger {
    <<interface>>
    LogDebug(message : string)
    LogInformation(message : string)
    LogWarning(message : string)
    LogError(e : exception, message : string)
    Configure(configuration : IConfiguration)
  }
  class SerilogLogger {
    +LogDebug(message : string)
    +LogInformation(message : string)
    +LogWarning(message : string)
    +LogError(e : exception, message : string)
    +Configure(configuration : IConfiguration)
  }
  ILogger <|.. SerilogLogger : Implements
  class OtherLogger {
    +LogDebug(message : string)
    +LogInformation(message : string)
    +LogWarning(message : string)
    +LogError(e : exception, message : string)
    +Configure(configuration : IConfiguration)
  }
  ILogger <|.. OtherLogger : Implements
```

---

### Parts of Speech

```mermaid
classDiagram
  class ISerializable {
    <<interface>>
    GetObjectData()
  }
  class IEnumerable {
    <<interface>>
    GetEnumerator()
  }
  class IDisposable {
    <<interface>>
    Dispose()
  }
```