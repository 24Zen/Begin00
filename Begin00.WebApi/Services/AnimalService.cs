using System.Collections.Generic;
using System.Linq;

// ใช้ alias ให้ชัดเจน
using ZooModels = Begin00.Models;          // สำหรับ abstract Animal ของ Zoo
using WebApiModels = Begin00.WebApi.Models; // สำหรับ Animal ของ Web API

namespace Begin00.WebApi.Services
{
    public interface IAnimalService
    {
        IEnumerable<WebApiModels.Animal> GetAllAnimals();
        void AddAnimal(string type, string voice);
        bool RemoveAnimalByType(string type);
    }

    public class AnimalService : IAnimalService
    {
        private readonly Begin00.Services.Zoo _zoo;

        public AnimalService(Begin00.Services.Zoo zoo)
        {
            _zoo = zoo;
            SeedAnimals();
        }

        private void SeedAnimals()
        {
            if (_zoo.GetAllAnimals().Count == 0)
            {
                _zoo.AddAnimal("dog", "barks");
                _zoo.AddAnimal("cat", "meows");
                _zoo.AddAnimal("bird", "chirps");
                _zoo.AddAnimal("fish", "silent");
                _zoo.AddAnimal("duck", "quacks");
            }
        }

        public IEnumerable<WebApiModels.Animal> GetAllAnimals()
        {
            // แปลง ZooModels.Animal → WebApiModels.Animal
            return _zoo.GetAllAnimals().Select(a => new WebApiModels.Animal
            {
                Type = a.GetType().Name.ToLower(),
                Voice = a.Voice
            });
        }

        public void AddAnimal(string type, string voice)
        {
            _zoo.AddAnimal(type, voice);
        }

        public bool RemoveAnimalByType(string type)
        {
            return _zoo.RemoveAnimalByType(type);
        }
    }
}
