using Domain;
using Infrastructure.ApiResponse;
using Infrastructure.UserService;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller.UserController;

[ApiController]
[Route("api/[controller]")]
public class UserController(UserService service)
{
    [HttpGet]
    public async Task<Response<IEnumerable<User>>> GetUser()
    {
        var res = await service.GetUsersAsync();
        return res;
    }

    [HttpPost]
    public async Task<Response<bool>> AddUser(User user)
    {
        var res = await service.AddUserAsync(user);
        return res;
    }

    [HttpPut]
    public async Task<Response<bool>> UpdateUser(User user)
    {
        var res = await service.UpdateUserAsync(user);
        return res;
    }

    [HttpDelete]
    public async Task<Response<bool>> DeleteUser(int id)
    {
        var res = await service.DeleteUserAsync(id);
        return res;
    }

    [HttpGet("[action]/{id}")]
    public async Task<Response<User>> GetUser(int id)
    {
        var res = await service.GetUserByIdAsync(id);
        return res;
    }
    
    
}