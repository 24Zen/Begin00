using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using WebApiModels = Begin00.WebApi.Models;
using Begin00.WebApi.Services;
using System.Collections.Generic;
=======
using Begin00.Services;
using Begin00.Models;
using Begin00.Exceptions;
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2

namespace Begin00.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
<<<<<<< HEAD
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
=======
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


>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
    }

    public class AnimalRequest
    {
        public string Type { get; set; } = string.Empty;
        public string Voice { get; set; } = string.Empty;
    }
}
