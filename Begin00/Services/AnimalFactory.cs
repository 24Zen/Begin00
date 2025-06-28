using System;
using Begin00.Models;
using Begin00.Exceptions;

namespace Begin00.Services
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string voice)
        {
            switch (type.ToLower())
            {
                case "dog": return new Dog { Voice = voice };
                case "cat": return new Cat { Voice = voice };
                case "bird": return new Bird { Voice = voice };
                case "fish": return new Fish { Voice = voice };
                case "duck": return new Duck { Voice = voice };
                default:
                    throw new InvalidAnimalException($"Animal type '{type}' is not recognized.");
            }
        }
    }
}