using api.contracts.requests;
using api.models;

namespace api.repository;

public class todoRequestHandler: ConnectionHandler, IDBRequestHandler
{
    private string _connectionString;

    public todoRequestHandler()
    {
        _connectionString = GetConnectionString();
    }

    public IEnumerable<IModel> getAll()
    {
        throw new NotImplementedException();
        /*
         * select *
         * from [todo]
         */
    }

    public IModel getById(Guid id)
    {
        throw new NotImplementedException();
        /*
         * select *
         * from [todo]
         * where todo.id = {id}
         */
    }

    public IEnumerable<todo> getUsersTodos(Guid userID)
    {
        throw new NotImplementedException();
        /*
         * select *
         * from todo T 
         * where T.userID = {userId}
         */
    }

    public todo getUserTodoById(Guid id, Guid userID)
    {
        throw new NotImplementedException();
        /*
         * select *
         * from todo T
         * where T.Id = {id} and T.userID = {UserID}
         */
    }
    public bool create(IRequest request)
    {
        return false;
    }

    public bool update(IRequest request)
    {
        return false;
    }

    public bool delete(Guid id)
    {
        return false;
    }
}