using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataBase;
using WebApplication1.Model;

namespace WebApplication1.Controllers;
[ApiController]
[Route("/visits")]
public class VisitController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(StaticDataVisits.GetVisits());
    }
    [HttpGet("{id}")]
    public IActionResult GetVisit(int id)
    {
        return Ok(StaticDataVisits.GetVisit(id));
    }
    [HttpPost]
    public IActionResult AddVisits(Visit Visit)
    {
        StaticDataVisits.AddVisit(Visit);
        return Created();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteVisit(int id)
    {
        StaticDataVisits.DeleteVisit(id);
        return Ok(id);
    }

    [HttpPut("{id, Visit}")]
    public IActionResult EditVisit(int id, Visit Visit)
    {
        StaticDataVisits.EditVisit(id, Visit);
        return Ok(id);
    }
}