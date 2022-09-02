using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Superhero_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero 
                {
                    Id = 0,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = "Malibu"
                }
            };
            return Ok(heroes);
        }
    }
}
