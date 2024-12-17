using Domain;
using Infrastructure.ApiResponse;
using Infrastructure.JobService;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller.UserController;

[ApiController]
[Route("api/[controller]")]
public class JobController(JobService service) : ControllerBase
{
    [HttpGet]
    public async Task<Response<List<Job>>> GetJobs()
    {
        var res = await service.GetJobAsync();
        return res;
    }

    [HttpPost]
    public async Task<Response<Job>> PostJob(Job job)
    {
        var res = await service.AddJobAsync(job);
        return res;
    }

    [HttpPut]
    public async Task<Response<bool>> PutJob(Job job)
    {
        var res = await service.UpdateJobAsync(job);
        return res;
    }

    [HttpDelete]
    public async Task<Response<bool>> DeleteJob(int id)
    {
        var res = await service.DeleteJobAsync(id);
        return res;
    }
}