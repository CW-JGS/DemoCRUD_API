using api.contracts.requests;
using api.models;
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

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var allUsers = _requestHandler.getAll();
        try
        {
            var returnData = Ok(allUsers.ToList());
            return returnData;
        }
        catch (BadHttpRequestException err)
        {
            return BadRequest(err);
        }
        catch (Exception err)
        {
            return NotFound(err);
        }
        
    }

    [HttpGet("{userID}")]
    public async Task<IActionResult> GetByID(Guid userID)
    {
        var singleUser = _requestHandler.getById(userID);
        try
        {
            var returnData = Ok(singleUser);
            return returnData;
        }
        catch (BadHttpRequestException err)
        {
            return BadRequest(err);
        }
        catch (Exception err)
        {
            return NotFound(err);
        }
    }

    public async Task<IActionResult> Post(CreateUserRequest request)
    {
        
    }
}