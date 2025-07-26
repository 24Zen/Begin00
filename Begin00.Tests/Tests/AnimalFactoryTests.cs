using Xunit;
using Begin00.Services;
using Begin00.Models;
using Begin00.Exceptions;

namespace Begin00.Tests
{
    public class AnimalFactoryTests
    {
        [Theory]
        [InlineData("dog", "bark", typeof(Dog))]
        [InlineData("cat", "meows", typeof(Cat))]
        [InlineData("bird", "chirps", typeof(Bird))]
        [InlineData("fish", "silent", typeof(Fish))]
        [InlineData("duck", "quacks", typeof(Duck))]
        public void CreateAnimal_ValidType_ReturnsCorrectAnimal(string type, string sound, Type expectedType)
        {
            var factory = new AnimalFactory();
            var animal = factory.CreateAnimal(type, sound);
            Assert.IsType(expectedType, animal);
        }

        [Fact]
        public void CreateAnimal_InvalidType_ThrowsException()
        {
            var factory = new AnimalFactory();
            Assert.Throws<InvalidAnimalException>(() => factory.CreateAnimal("lion", "roar"));
        }
    }
}
