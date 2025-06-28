Detailed Breakdown
Base Class Animal (abstract class):
Defines a property Voice (the sound the animal makes) and an abstract method Speak() that each animal class must override to output its sound.

Interfaces:

IFlyable — defines a Fly() method for animals that can fly.

ISwimmable — defines a Swim() method for animals that can swim.

Animal Classes (Bird, Cat, Dog, Fish, Duck):
Each inherits from Animal and implements interfaces as appropriate (e.g., Bird and Duck implement IFlyable, Dog and Fish implement ISwimmable).

AnimalFactory:
Creates and returns the correct animal object based on the input type and voice. This separates the object creation logic from the rest of the program.

Zoo (Service class):
Maintains a list of animals, provides methods to add animals (AddAnimal) and to display all animals (ShowAllAnimals). When displaying, it calls Speak() and invokes special ability methods if implemented.

Program.cs (Main entry point):
Runs the program, adds some initial animals, and then enters a loop to receive user input to add more animals or exit. It continuously shows all animals after each addition.

InvalidAnimalException:
A custom exception thrown when the factory receives an unknown animal type, allowing the program to catch this and display an error message without crashing.
