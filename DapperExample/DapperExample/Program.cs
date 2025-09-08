// See https://aka.ms/new-console-template for more information
using DapperExample;

internal static class Program
{
    public static void Main(string[] args)
    {
        var repo = new ActorRepository();

        var test = new Actor
        {
            First_Name = "Strong",
            Last_Name = "Man",
            Last_Update = DateTime.Now
        };

        test = repo.CreateActor(test);
        
        Console.WriteLine(test.Actor_Id);
    }
}