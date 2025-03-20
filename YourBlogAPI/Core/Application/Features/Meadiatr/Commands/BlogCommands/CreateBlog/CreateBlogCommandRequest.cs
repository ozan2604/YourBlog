using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.CreateBlog
{
    public class CreateBlogCommandRequest : BaseEntity , IRequest<CreateBlogCommandResponse> 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
