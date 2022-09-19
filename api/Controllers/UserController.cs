using api.repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

public class UserController: ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private userRequestHandler _requestHandler;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
        _requestHandler = new userRequestHandler();
    }
}