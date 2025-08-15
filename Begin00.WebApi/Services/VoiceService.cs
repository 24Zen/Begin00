using Begin00.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Begin00.WebApi.Services
{
    public class VoiceService : IVoiceService
    {
        private readonly List<VoiceDTO> _voices = new();
        private int _nextId = 1;

        public IEnumerable<VoiceDTO> GetAllVoices() => _voices;

        public VoiceDTO? GetVoiceById(int id)
        {
            return _voices.FirstOrDefault(v => v.Id == id);
        }

        public VoiceDTO AddVoice(VoiceDTO voiceDto)
        {
            voiceDto.Id = _nextId++;
            _voices.Add(voiceDto);
            return voiceDto;
        }

        public bool DeleteVoice(int id)
        {
            var voice = _voices.FirstOrDefault(v => v.Id == id);
            if (voice == null) return false;
            _voices.Remove(voice);
            return true;
        }
    }
}
