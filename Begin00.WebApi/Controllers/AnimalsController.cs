using Microsoft.AspNetCore.Mvc;
using WebApiModels = Begin00.WebApi.Models;
using Begin00.WebApi.Services;
using System.Collections.Generic;

namespace Begin00.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WebApiModels.Animal>> GetAnimals()
        {
            return Ok(_animalService.GetAllAnimals());
        }

        [HttpPost]
        public ActionResult AddAnimal([FromBody] AnimalRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Type) || string.IsNullOrWhiteSpace(request.Voice))
                return BadRequest(new { error = "Type and Voice are required." });

            _animalService.AddAnimal(request.Type, request.Voice);
            return Ok(new { message = "Animal added successfully." });
        }

        [HttpDelete("{type}")]
        public ActionResult DeleteAnimal(string type)
        {
            if (!_animalService.RemoveAnimalByType(type))
                return NotFound(new { error = $"{type} not found." });

            return Ok(new { message = $"{type} removed." });
        }
    }

    public class AnimalRequest
    {
        public string Type { get; set; } = string.Empty;
        public string Voice { get; set; } = string.Empty;
    }
}
