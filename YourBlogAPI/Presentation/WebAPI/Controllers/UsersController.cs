using Application.Features.Meadiatr.Commands.AppUserCommands.CreateUser;
using Application.Features.Meadiatr.Commands.AppUserCommands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]  
        public async Task<IActionResult> CreateUser([FromQuery] CreateAppUserCommandRequest request)
        {
            CreateAppUserCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost("Action")]
        public async Task<IActionResult> Login( LoginUserCommandRequest request)
        {
            LoginUserCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
