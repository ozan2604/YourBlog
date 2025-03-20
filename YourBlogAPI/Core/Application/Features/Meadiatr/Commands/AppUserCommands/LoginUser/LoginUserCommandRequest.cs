﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.AppUserCommands.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>    
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
