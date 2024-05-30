using Tasks;
namespace Tasks.Models;
public class User
{
    
    public int Id { get; set; } 
    public string UserName { get; set; }
    public int IsAdmin { get; set; }
    public string Password { get; set; }

}