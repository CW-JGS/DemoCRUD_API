using api.contracts.requests;
using api.models;
namespace api.repository;

public interface IDBRequestHandler
{
    public IEnumerable<IModel> getAll();
    public IModel getById(Guid id);
    public bool create(CreateUserRequest req);
    public bool update(UpsertUserRequest req);
    public bool delete(Guid id);
}