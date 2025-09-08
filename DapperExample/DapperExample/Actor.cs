using Dapper.Contrib.Extensions;

namespace DapperExample;

[Table("Actor")]
public class Actor
{
    [Key]
    public int Actor_Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public DateTime Last_Update { get; set; }
    private int Test { get; set; }
    
}