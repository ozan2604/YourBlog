using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.RemoveBlog
{
    public class RemoveBlogCommandRequest : IRequest<RemoveBlogCommandResponse> 
    {
        public string Id { get; set; }  
    }
}
