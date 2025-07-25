using System;
using System.Collections.Generic;

using Begin00.Exceptions;
using Begin00.Interfaces;
using Begin00.Models;
using Begin00.ConsoleUI;
using Begin00.ConsoleUI.Interfaces;
namespace Begin00.Services
{

    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();
        private AnimalFactory factory = new AnimalFactory();
        private AnimalManager animalVoices = new AnimalManager();

        // เพิ่มมาใหม่ เอาไว้อ่านและรับค่า Get จาก http
        public IReadOnlyList<Animal> GetAllAnimals()
        {
            return animals.AsReadOnly();
        }
        // เพิ่มมาใหม่ เอาไว้อ่านและรับค่า Get จาก http

        // ค้นหา Animal
        public Animal? FindAnimalByType(string type)
        {
            return animals.FirstOrDefault(a => a.GetType().Name.ToLower() == type.ToLower());
        }
        // ค้นหา Animal


        // ค้นหา Voice
        public Animal? FindVoiceByType(string type)
        {
            return voicesAnimal.FirstOrDefault(a => a.GetType().Name.ToLower() == type.ToLower());
        }
        // ค้นหา Voice


        // ลบ Animal
        public bool RemoveAnimalByType(string type)
        {
            var animal = FindAnimalByType(type);
            if (animal != null)
            {
                animals.Remove(animal);
                return true;
            }
            return false;
        }
        // ลบ Animal


        // ลบ Voice
        public bool RemoveVoiceByType(string type)
        {
            var voiceAnimal = FindVoiceByType(type);
            if (voiceAnimal != null)
            {
                voicesAnimal.Remove(voiceAnimal);
                return true;
            }
            return false;
        }
        // ลบ Voice


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

        public void AddVoice(string type, string voice)
        {
            try
            {
                var voiceAnimal = voicesAnimal.CreateAnimal(type, voiceAnimal);
                animals.Add(voiceAnimal);
            }
            catch (InvalidAnimalException ex)
            {
                Console.WriteLine($"Cannot add voice for animal: {ex.Message}");
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