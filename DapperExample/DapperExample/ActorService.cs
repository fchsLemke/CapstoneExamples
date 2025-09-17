namespace DapperExample;

public class ActorService
{
    private readonly ActorRepository _actorRepository;

    public ActorService(ActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }
    
    public Actor CreateActor(Actor actor)
    {
        return _actorRepository.CreateActor(actor);
    }
    
    public Actor UpdateActor(Actor actor)
    {
        if (actor.Actor_Id == 0)
            throw new Exception("Actor id can't be 0");
        var existingActor = _actorRepository.GetActorById(actor.Actor_Id);
        if (existingActor == null)
            throw new Exception("Actor not found");
        return _actorRepository.UpdateActor(actor);
    }
    
    public Actor GetActorById(int id)
    {
        var result = _actorRepository.GetActorById(id);
        if (result == null)
            throw new Exception("Actor not found");
        return result;
    }
    
    public bool DeleteActor(int id)
    {
        var actor = _actorRepository.GetActorById(id);
        if (actor == null)
            throw new Exception("Actor not found");
        return _actorRepository.DeleteActor(id);
    }
}