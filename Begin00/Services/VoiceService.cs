using Begin00.Models;
using System.Collections.Generic;
using System.Linq;

namespace Begin00.Services
{
    public class VoiceService : IVoiceService
    {
        private readonly List<Voice> _voices = new();
        private int _nextId = 1;

        public IEnumerable<Voice> GetAllVoices() => _voices;

        public Voice AddVoice(Voice voice)
        {
            voice.Id = _nextId++;
            _voices.Add(voice);
            return voice;
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
