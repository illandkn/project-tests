using Application.Models;
using Application.Models.User;
using Application.Services.Token;
using Application.Services.User;
using Domain.Interfaces.UserRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRequestModel request)
        {
            await _userService.Create(request);
            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UserRequestModel request)
        {
            await _userService.Update(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromBody] Guid id)
        {
            await _userService.Delete(id);
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<UserResponseModel> GetById([FromRoute] Guid id)
        {
            return await _userService.GetById(id);
        }

        [HttpGet]
        public async Task<IList<UserResponseModel>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserLoginModelBase request)
        {
            return await _userService.Authenticate(request);
        }

        //[HttpGet]
        //[Route("employee")]
        //[Authorize(Roles = "employee,manager")]
        //public string Employee() => "Funcionário";

        //[HttpGet]
        //[Route("manager")]
        //[Authorize(Roles = "manager")]
        //public string Manager() => "Gerente";
    }
}
