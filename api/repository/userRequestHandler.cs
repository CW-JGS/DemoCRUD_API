using api.contracts.requests;
using api.models;
namespace api.repository;

public class userRequestHandler: ConnectionHandler, IDBRequestHandler
{
    private string _connectionString;

    public userRequestHandler()
    {
        _connectionString = GetConnectionString();
    }

    public IEnumerable<IModel> getAll()
    {
        throw new NotImplementedException();
    }

    public IModel getById(Guid userID)
    {
        throw new NotImplementedException();
    }

    public bool create(CreateUserRequest request)
    {
        return false;
    }

    public bool update(UpsertUserRequest request)
    {
        return false;
    }

    public bool delete(Guid UserID)
    {
        return false;
    }
    

}