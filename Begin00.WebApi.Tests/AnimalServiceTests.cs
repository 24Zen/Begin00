using Xunit;
using Begin00.WebApi.Services;

namespace Begin00.WebApi.Tests
{
    public class AnimalServiceTests
    {
        [Fact]
        public void AddAnimal_ShouldAddAnimalSuccessfully()
        {
            // Arrange
            var zoo = new Begin00.Services.Zoo();
            var service = new AnimalService(zoo);

            // Act
            service.AddAnimal("cat", "meow");

            // Assert
            var animals = service.GetAllAnimals();
            Assert.Contains(animals, a => a.Type == "cat");
        }

        [Fact]
        public void AddMultipleAnimals_ShouldContainAll()
        {
            // Arrange
            var zoo = new Begin00.Services.Zoo();
            var service = new AnimalService(zoo);

            // Act
            service.AddAnimal("dog", "woof");
            service.AddAnimal("duck", "quack");

            // Assert
            var animals = service.GetAllAnimals();
            Assert.Contains(animals, a => a.Type == "dog");
            Assert.Contains(animals, a => a.Type == "duck");
        }
    }
}
