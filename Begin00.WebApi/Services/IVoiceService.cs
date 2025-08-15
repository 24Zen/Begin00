using Begin00.WebApi.Models;
using System.Collections.Generic;

namespace Begin00.WebApi.Services
{
    public interface IVoiceService
    {
        IEnumerable<VoiceDTO> GetAllVoices();
        VoiceDTO? GetVoiceById(int id);
        VoiceDTO AddVoice(VoiceDTO voiceDto);
        bool DeleteVoice(int id);
    }
}
