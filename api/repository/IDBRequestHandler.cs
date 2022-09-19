using api.contracts.requests;
using api.models;
namespace api.repository;

public interface IDBRequestHandler
{
    public IEnumerable<IModel> getAll();
    public IModel getById(Guid id);
    public bool create(IRequest req);
    public bool update(IRequest req);
    public bool delete(Guid id);
}