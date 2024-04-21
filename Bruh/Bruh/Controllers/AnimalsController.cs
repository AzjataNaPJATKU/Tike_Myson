using Microsoft.AspNetCore.Mvc;

namespace Bruh.Controllers;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        return Ok(id);
    }
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}