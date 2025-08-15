using Begin00.Models;
using System.Collections.Generic;

namespace Begin00.Services
{
    public interface IVoiceService
    {
        IEnumerable<Voice> GetAllVoices();
        Voice AddVoice(Voice voice);
        bool DeleteVoice(int id);
    }
}
