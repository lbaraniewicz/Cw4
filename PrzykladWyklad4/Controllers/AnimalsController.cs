using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrzykladWyklad4.Models;
using PrzykladWyklad4.Services;
using System.Threading.Tasks;

namespace PrzykladWyklad4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalsDbService _dbAnimals;
        public AnimalsController(IAnimalsDbService dbAnimals)
        {
            _dbAnimals = dbAnimals;
        }

        [HttpGet]
        public IActionResult GetAnimals()
        {
            return Ok(_dbAnimals.GetAnimals());
        }

        [HttpPost]
        public IActionResult InsertAnimal(Animal newAnimal)
        {
            return Ok(_dbAnimals.InsertAnimal(newAnimal));
        }
        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Animal value)
        {
            if (id < 0) return BadRequest("Wprowadzono błędne id");
            return Ok("Zaktualizowano " + _dbAnimals.UpdateAnimal(value, id));
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest("Wprowadzono błędne id");
            return Ok("Usunięto " + _dbAnimals.DeleteAnimal(id));
        }
    }
}
