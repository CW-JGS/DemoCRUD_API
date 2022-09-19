namespace api.contracts.requests;

public record CreateTodoRequest(Guid CreatorID, string todoHeading, string todoBody) : IRequest;