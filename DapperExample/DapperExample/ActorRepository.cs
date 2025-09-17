using Dapper.Contrib.Extensions;
using MySqlConnector;

namespace DapperExample;

public class ActorRepository
{
    
    private static readonly string ConnectionString = "Server=localhost;database=sakila;Uid=root;Password=admin;Port=3306;";
    
    public Actor CreateActor(Actor actor)
    {
        //add an actor to the db
        using var connection = new MySqlConnection(ConnectionString);
        
        var id = connection.Insert(actor);
        actor.Actor_Id = (int) id;
        return actor;
        //capstone students rule
    }
    
    public Actor UpdateActor(Actor actor)
    {
        //update an actor in the db
        using var connection = new MySqlConnection(ConnectionString);
        
        var success = connection.Update(actor);
        if (success)
            return actor;
        else
            throw new Exception("Error updating post");
    }
    
    public Actor GetActorById(int id)
    {
        //get an actor in the db
        using var connection = new MySqlConnection(ConnectionString);
        
        var actor = connection.Get<Actor>(id);

        return actor;
    }
    
    public bool DeleteActor(int id)
    {
        //get an actor in the db
        using var connection = new MySqlConnection(ConnectionString);
        
        var success = connection.Delete(new Actor {Actor_Id = id});
        
        if (success)
            return true;
        else
            throw new Exception("Error deleting post");
        
    }

}