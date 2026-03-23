namespace UserServices;

public class Person
{
    // Person which contain (Id,Name,Age,Email,Password)
    public int Id {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    public string Email {get; set;}
    public string Password {get; set;}

     // Simple check
    public bool VerifyPassword(string password)
    {
        return Password == password;
    }
}
