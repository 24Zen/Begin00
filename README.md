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


Build and run the program:

bash
Copy
Edit
dotnet run --project Begin00/Begin00.csproj
Follow the console prompts to add animals or exit the program.

Usage Example
plaintext
Copy
Edit
Dog: barks
Cat: meows
Bird: chirps
Fish: silent
Duck: quacks
Bird is flying!
Dog is swimming!
Fish is swimming!
Duck is flying!
Duck is swimming!

Enter animal type:
> lion
Enter animal voice:
> roar
Cannot add animal: Animal type 'lion' is not recognized.

Enter animal type (or type 'exit' to quit):
> exit
Exiting program...
Project Structure
yaml
Copy
Edit
Begin00/
├── Begin00/             # Main project folder
│   ├── Models/          # Animal classes and base abstract class
│   ├── Interfaces/      # IFlyable and ISwimmable interfaces
│   ├── Services/        # Zoo and AnimalFactory classes
│   ├── Exceptions/      # Custom exceptions
│   ├── Program.cs       # Main program entry point
│   └── Begin00.csproj   # Project file
├── Begin00.Tests/       # Unit tests using xUnit
│   └── AnimalFactoryTests.cs
└── README.md            # This file
Running Tests
To run unit tests for the project:

bash
Copy
Edit
dotnet test Begin00.Tests/Begin00.Tests.csproj
