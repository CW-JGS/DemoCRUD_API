using api.Middleware;
// this is a basic model
namespace api.models;
// we use the public access modifier to make sure only the api is about to access it
public partial class User:  IModel
{
    public Guid UserID { get; init; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Salt { get; init; }
    public string Username { get; set; }
    public DateTime CreatedAt { get; init; }
    public DateTime LastUpdated { get; set; }
    public User(string _paramFirstName, string _paramSurName,string _paramEmail, string _paramPassword, string _paramUserName)
    {
        UserID = new Guid();
        CreatedAt = DateTime.Now;
        LastUpdated = DateTime.Now;
        Salt = new SaltGen().Salt;
        FirstName = _paramFirstName;
        SurName = _paramSurName;
        Email = _paramEmail;
        Password = _paramPassword;
        Username = _paramUserName;
    }

}
