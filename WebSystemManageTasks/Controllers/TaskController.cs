using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSystemManageTasks.Controllers
{
    /// <summary>
    /// Контроллер задач
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("Task")]
    public class TaskController : Controller
    {
        [HttpPost("Test")]
        public async Task<IResult> Test()
        {
            return Results.Ok();
        }
    }
}
