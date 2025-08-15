using System;
using System.Collections.Generic;
using Begin00.Models;
using Begin00.Exceptions;

namespace Begin00.Services
{
    public class AnimalFactory
    {
        private readonly Dictionary<string, Func<string, Animal>> creators = new()
        {
            { "dog", voice => new Dog { Voice = voice } },
            { "cat", voice => new Cat { Voice = voice } },
            { "bird", voice => new Bird { Voice = voice } },
            { "fish", voice => new Fish { Voice = voice } },
            { "duck", voice => new Duck { Voice = voice } }
        };

        public Animal CreateAnimal(string type, string voice)
        {
            if (creators.TryGetValue(type.ToLower(), out var creator))
            {
                return creator(voice);
            }
            throw new InvalidAnimalException($"Animal type '{type}' is not recognized.");
        }
    }
}
