using DapperExample;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class ActorController : Controller
{
    private readonly ActorService _actorService;

    public ActorController()
    {
        var repo = new ActorRepository();
        _actorService = new ActorService(repo);
    }
    
    [HttpGet("actor/{id:int}")]
    public IActionResult Actor([FromRoute]int id)
    {
        var result = _actorService.GetActorById(id);

        return Ok(result);
    }

    [HttpPost("actor")]
    public IActionResult Actor([FromBody] Actor actor)
    {
        throw new System.NotImplementedException();
    }
}