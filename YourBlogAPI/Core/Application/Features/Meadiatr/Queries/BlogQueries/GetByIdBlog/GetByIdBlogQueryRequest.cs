using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Queries.BlogQueries.GetByIdBlog
{
    public class GetByIdBlogQueryRequest : IRequest<GetByIdBlogQueryResponse>
    {
        public string Id { get; set; }
    }
}
