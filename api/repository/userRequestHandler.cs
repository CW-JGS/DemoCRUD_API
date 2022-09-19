using api.models;
namespace api.repository;

public class userRequestHandler: ConnectionHandler, IDBRequestHandler
{
    private string _connectionString;

    public userRequestHandler()
    {
        _connectionString = GetConnectionString();
    }

    public IEnumerable<User> getAllUsers()
    {
        throw new NotImplementedException();
    }

    public User getUserByUUID(Guid userID)
    {
        throw new NotImplementedException();
    }

    public bool createUser( /* add in upsert contract*/)
    {
        return false;
    }

    public bool updateUser( /* use upsert contract */)
    {
        return false;
    }

    public bool deleteUser(Guid UserID)
    {
        return false;
    }
    

}