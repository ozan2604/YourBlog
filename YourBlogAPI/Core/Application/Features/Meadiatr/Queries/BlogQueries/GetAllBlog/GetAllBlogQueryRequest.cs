using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Queries.BlogQueries.GetAllBlog
{
    public class GetAllBlogQueryRequest : BaseEntity , IRequest<GetAllBlogQueryResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }    
    }
}
