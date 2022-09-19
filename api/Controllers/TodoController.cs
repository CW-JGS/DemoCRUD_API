using api.repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

public class TodoController: ControllerBase
{
    // set up
    private readonly ILogger<TodoController> _logger;
    private todoRequestHandler _requestHandler;
    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
        _requestHandler = new todoRequestHandler();
    }
    // routes 
}