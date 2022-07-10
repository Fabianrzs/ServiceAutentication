using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAutentication.Models;
using WebApiAutentication.Repository;
using WebApiAutentication.Service;

namespace WebApiAutentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserRepository _repository;
        private IJwtService _jwtService;
        public LoginController(IUserRepository repository, IJwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;

        }

        [AllowAnonymous]
        [HttpPost()]
        public IActionResult Login([FromBody] Login login)
        {
            var user = _repository.UserLogin(login.UserName, login.Password);
            if (user == null)
            {
                ModelState.AddModelError("Acceso Denegado", "Username or password is incorrect");
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(problemDetails);
            }
            var response = _jwtService.GenerateToken(user);
            return Ok(response);
        }

    }
}
