using Xunit;
using Begin00.WebApi.Models;
using Begin00.WebApi.Services;

namespace Begin00.WebApi.Tests
{
    public class VoiceServiceTests
    {
        [Fact]
        public void AddVoice_ShouldAddVoiceSuccessfully()
        {
            var service = new VoiceService();

            var voiceDto = new VoiceDTO
            {
                AnimalName = "Cat",
                Sound = "Meow"
            };

            var created = service.AddVoice(voiceDto);

            var voices = service.GetAllVoices();
            Assert.Contains(voices, v => v.Id == created.Id);
        }

        [Fact]
        public void AddMultipleVoices_ShouldContainAll()
        {
            var service = new VoiceService();

            var voice1 = new VoiceDTO { AnimalName = "Dog", Sound = "Woof" };
            var voice2 = new VoiceDTO { AnimalName = "Duck", Sound = "Quack" };

            var created1 = service.AddVoice(voice1);
            var created2 = service.AddVoice(voice2);

            var voices = service.GetAllVoices();
            Assert.Contains(voices, v => v.Id == created1.Id);
            Assert.Contains(voices, v => v.Id == created2.Id);
        }
    }
}
