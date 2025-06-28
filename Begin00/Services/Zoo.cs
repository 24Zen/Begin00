using System;
using System.Collections.Generic;

using Begin00.Exceptions;
using Begin00.Interfaces;
using Begin00.Models;

namespace Begin00.Services
{

    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();
        private AnimalFactory factory = new AnimalFactory();

        public void AddAnimal(string type, string voice)
        {
            try
            {
                var animal = factory.CreateAnimal(type, voice);
                animals.Add(animal);
            }
            catch (InvalidAnimalException ex)
            {
                Console.WriteLine($"Cannot add animal: {ex.Message}");
            }
        }

        public void ShowAllAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Speak();

                if (animal is IFlyable flyer) flyer.Fly();
                if (animal is ISwimmable swimmer) swimmer.Swim();
            }
        }
    }
}