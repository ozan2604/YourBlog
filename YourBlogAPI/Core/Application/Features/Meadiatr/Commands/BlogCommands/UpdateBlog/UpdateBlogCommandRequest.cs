using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.UpdateBlog
{
    public class UpdateBlogCommandRequest : IRequest<UpdateBlogCommandResponse>
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
