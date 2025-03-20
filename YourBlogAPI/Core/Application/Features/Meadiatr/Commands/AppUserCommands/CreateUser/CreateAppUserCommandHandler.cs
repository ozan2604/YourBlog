using Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.AppUserCommands.CreateUser
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommandRequest, CreateAppUserCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public CreateAppUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateAppUserCommandResponse> Handle(CreateAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = _userManager.CreateAsync(new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email,
                NameSurname = request.NameSurname,
            }, request.Password).Result;

            CreateAppUserCommandResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
                response.Message = "User created successfully";

            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}";

            return response;
        }
    }
}
