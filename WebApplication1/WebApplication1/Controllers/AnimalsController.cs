using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataBase;
using WebApplication1.Model;

namespace WebApplication1.Controllers;


[ApiController]
[Route("/animals")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(StaticData.GetAnimals());
    }
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        return Ok(StaticData.GetAnimal(id));
    }
    [HttpPost]
    public IActionResult AddAnimals(Animal animal)
    {
        StaticData.AddAnima(animal);
        return Created();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        StaticData.DeleteAnimal(id);
        return Ok(id);
    }

    [HttpPut("{id, animal}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        StaticData.EditAnimal(id, animal);
        return Ok(id);
    }
}