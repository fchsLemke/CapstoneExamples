using DapperExample;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class ActorController : Controller
{
    private readonly ActorService _actorService;
    
    public ActorController()
    {
        var actorRepo = new ActorRepository();
        _actorService = new ActorService(actorRepo);
    }
    
    [HttpGet("/actor/{actorId:int}")]
    public IActionResult GetActor([FromRoute] int actorId)
    {
        var result = _actorService.GetActorById(actorId);
        
        return Ok(result);
    }
    
    [HttpGet("/actor")]
    public IActionResult GetActors()
    {
        throw new NotImplementedException("I haven't done this yet.");
    }

    [HttpPost("/actor")]
    public IActionResult CreateActor([FromBody] Actor actor)
    {
        var result = _actorService.CreateActor(actor);
        return Ok(result);
    }

    [HttpDelete("/actor/{actorId:int}")]
    public IActionResult DeleteActor([FromRoute] int actorId)
    {
        var result = _actorService.DeleteActor(actorId);
        return NoContent();
    }
}