using Microsoft.AspNetCore.Mvc;
using GeneralServices.Services.Interfaces;

namespace GeneralServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("validate")]
        public async Task<IActionResult> Validate(string username, string password)
        {
            var isValid = await _service.ValidateUserAsync(username, password);

            if (!isValid)
                return Unauthorized("Invalid credentials");

            return Ok("User is valid");
        }
    }
}