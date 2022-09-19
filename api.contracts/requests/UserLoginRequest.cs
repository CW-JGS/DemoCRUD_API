namespace api.contracts.requests;

public record UserLoginRequest(
    Guid? UserID,
    string? email,
    string? username,
    string password);