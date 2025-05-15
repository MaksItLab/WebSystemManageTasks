using Microsoft.AspNetCore.Mvc;
using WebSystemManageTasks.Interfaces.Services;
using WebSystemManageTasks.Requests;

namespace WebSystemManageTasks.Controllers
{
    /// <summary>
    /// Контроллер для аутентификации
    /// </summary>
    [ApiController]
    [Route("Auth")]
    public class AuthController : Controller
    {
        /// <summary>
        /// Аутентификация
        /// </summary>
        /// <param name="request">Запрос</param>
        /// <param name="service">Сервис аутентификации</param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<IResult> LoginAsync(
            [FromQuery] LoginRequest request, 
            [FromServices] IAuthService service)
        {
            var token = await service.LoginAsync(request.Login, request.Password);

            Response.Cookies.Append("token", token);
            
            return Results.Ok(token);
        }

        /// <summary>
        /// Регистрация нового пользователя
        /// </summary>
        /// <param name="request">Запрос</param>
        /// <param name="service">Сервис аутентификации</param>
        /// <returns></returns>
        [HttpPost("Register")]
        public async Task<IResult> RegisterAsync([FromQuery] RegisterRequest request, [FromServices] IAuthService service)
        {
            var token = await service.RegisterAsync(
                request.Login, 
                request.Password, 
                request.Email, 
                request.Name, 
                request.Surname);

            Response.Cookies.Append("token", token);

            return Results.Ok(token);
        }
    }
}
