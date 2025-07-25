using Microsoft.AspNetCore.Mvc;
using Begin00.Services;
using Begin00.Models;
using Begin00.Exceptions;

namespace Begin00.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly Zoo _zoo = new();

        public AnimalsController()
        {
            _zoo.AddAnimal("dog", "barks");
            _zoo.AddAnimal("cat", "meows");
            _zoo.AddAnimal("bird", "chirps");
            _zoo.AddAnimal("fish", "silent");
            _zoo.AddAnimal("duck", "quacks");
        }

        [HttpGet]
        public IActionResult GetAnimals()
        {
            return Ok(_zoo.GetAllAnimals());
        }

        [HttpPost]
        public IActionResult AddAnimal([FromBody] AnimalRequest request)
        {
            try
            {
                _zoo.AddAnimal(request.Type, request.Voice);
                return Ok(new { message = "Animal added successfully." });
            }
            catch (InvalidAnimalException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // ลบ Aminal
        [HttpDelete("{type}")]
        public IActionResult DeleteAnimal(string type)
        {
            var success = _zoo.RemoveAnimalByType(type);
            if (success)
                return Ok(new { message = $"{type} removed." });
            else
                return NotFound(new { error = $"{type} not found." });
        }
        // ลบ Aminal


    }

    public class AnimalRequest
    {
        public string Type { get; set; } = string.Empty;
        public string Voice { get; set; } = string.Empty;
    }
}
