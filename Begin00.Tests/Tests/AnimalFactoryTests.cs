using Xunit;
using Begin00.Services;
using Begin00.Models;
using Begin00.Exceptions;

namespace Begin00.Tests
{
    public class AnimalFactoryTests
    {
        [Fact]
        public void CreateAnimal_ValidType_ReturnsCorrectAnimal()
        {
            var factory = new AnimalFactory();

            var dog = factory.CreateAnimal("dog", "bark");
            Assert.IsType<Dog>(dog);

            var cat = factory.CreateAnimal("cat", "meows");
            Assert.IsType<Cat>(cat);

            var bird = factory.CreateAnimal("bird", "chirps");
            Assert.IsType<Bird>(bird);

            var fish = factory.CreateAnimal("fish", "silent");
            Assert.IsType<Fish>(fish);

            var duck = factory.CreateAnimal("duck", "quacks");
            Assert.IsType<Duck>(duck);

        }
        [Fact]
        public void CreateAnimal_InvalidType_ThrowsException()
        {
            var factory = new AnimalFactory();
            Assert.Throws<InvalidAnimalException>(() => factory.CreateAnimal("lion", "roar"));
        }
    }
}