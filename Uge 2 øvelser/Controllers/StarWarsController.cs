using Microsoft.AspNetCore.Mvc;
using Pew;
using Pew.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarWarsController : ControllerBase
    {
        private readonly StarWarsLogic starWarsLogic;

        public StarWarsController(StarWarsLogic starWarsLogic)
        {
            this.starWarsLogic = starWarsLogic;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            StarWarsPerson person = await starWarsLogic.GetPerson(id);

            if (person != null)
            {
                return Ok(person);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}