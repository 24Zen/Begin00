using Begin00.WebApi.Models;
using Begin00.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Begin00.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoiceController : ControllerBase
    {
        private readonly IVoiceService _voiceService;

        public VoiceController(IVoiceService voiceService)
        {
            _voiceService = voiceService;
        }

        // GET: api/voice
        [HttpGet]
        public ActionResult<IEnumerable<VoiceDTO>> GetAll()
        {
            return Ok(_voiceService.GetAllVoices());
        }

        // GET: api/voice/5
        [HttpGet("{id}")]
        public ActionResult<VoiceDTO> GetById(int id)
        {
            var voice = _voiceService.GetVoiceById(id);
            if (voice == null) return NotFound();
            return Ok(voice);
        }

        // POST: api/voice
        [HttpPost]
        public ActionResult<VoiceDTO> Create([FromBody] VoiceDTO voiceDto)
        {
            if (voiceDto == null) return BadRequest();
            var created = _voiceService.AddVoice(voiceDto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // DELETE: api/voice/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _voiceService.DeleteVoice(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
