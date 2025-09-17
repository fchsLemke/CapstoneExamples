// See https://aka.ms/new-console-template for more information
using DapperExample;

internal static class Program
{
    public static void Main(string[] args)
    {
        var repo = new ActorRepository();
        var service = new ActorService(repo);
        
        
        var test = new Actor
        {
            Actor_Id = 2,
            First_Name = "Weak",
            Last_Name = "Man",
            Last_Update = DateTime.Now
        };

        test = service.UpdateActor(test);
        
        Console.WriteLine(test.Actor_Id);
    }
}