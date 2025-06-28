# Animal Zoo Console Application

A simple console application in C# demonstrating Object-Oriented Programming concepts such as abstraction, inheritance, interfaces, and the Factory design pattern.

---

## Overview

This project models a zoo with various animals, each having its own sound and special abilities like flying or swimming.

### Key Features

- **Abstract Base Class:** `Animal` defines a common structure for all animals with a `Voice` property and an abstract `Speak()` method.
- **Interfaces:**  
  - `IFlyable` — animals that can fly implement this interface with a `Fly()` method.  
  - `ISwimmable` — animals that can swim implement this interface with a `Swim()` method.
- **Animal Classes:** Specific animals (`Bird`, `Cat`, `Dog`, `Fish`, `Duck`) inherit from `Animal` and implement interfaces as appropriate.
- **Factory Pattern:** `AnimalFactory` creates instances of animals based on input, abstracting object creation logic.
- **Zoo Service:** Manages a collection of animals, adding new animals and displaying their sounds and abilities.
- **Custom Exception:** `InvalidAnimalException` handles unknown animal types gracefully.

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Any C# IDE or editor (Visual Studio, VS Code, JetBrains Rider, etc.)

### How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name


