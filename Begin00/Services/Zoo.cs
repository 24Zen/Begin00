using System;
using System.Collections.Generic;
using System.Linq;
using Begin00.Exceptions;
using Begin00.Interfaces;
using Begin00.Models;
using Begin00.Managers;

namespace Begin00.Services
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();
        private AnimalFactory factory = new AnimalFactory();
        public VoiceManager VoiceManager { get; } = new VoiceManager();

        private int animalIdCounter = 1;

        public IReadOnlyList<Animal> GetAllAnimals() => animals.AsReadOnly();

        public IReadOnlyList<VoiceEntry> GetAllVoices() => VoiceManager.GetAllVoices();

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


        public void AddAnimal(string type, string voice)
        {
            try
            {
                var animal = factory.CreateAnimal(type, voice);
                animal.Id = animalIdCounter++;
                animals.Add(animal);
                VoiceManager.AddVoice(animal.Id, voice);
            }
            catch (InvalidAnimalException ex)
            {
                Console.WriteLine($"Cannot add animal: {ex.Message}");
            }
        }

        public void AddVoice(int animalId, string voiceText)
        {
            VoiceManager.AddVoice(animalId, voiceText);
        }

        public bool RemoveAnimalByType(string type)
        {
            var animal = animals.FirstOrDefault(a => a.GetType().Name.Equals(type, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                animals.Remove(animal);
                return true;
            }
            return false;
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

        public void ShowAllVoices()
        {
            foreach (var voice in VoiceManager.GetAllVoices())
            {
                Console.WriteLine($"AnimalId: {voice.AnimalId}, Voice: {voice.VoiceText}");
            }
        }
    }
}
