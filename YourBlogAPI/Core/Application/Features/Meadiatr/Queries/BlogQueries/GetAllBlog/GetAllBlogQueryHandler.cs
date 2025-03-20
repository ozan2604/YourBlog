using Application.Repositories.BlogRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Queries.BlogQueries.GetAllBlog
{
    public class GetAllBlogQueryHandler : IRequestHandler<GetAllBlogQueryRequest, GetAllBlogQueryResponse>  
    {
        public readonly IBlogReadRepository _blogReadRepository;

        public GetAllBlogQueryHandler(IBlogReadRepository blogReadRepository)
        {
            _blogReadRepository = blogReadRepository;
        }

        public async Task<GetAllBlogQueryResponse> Handle(GetAllBlogQueryRequest request, CancellationToken cancellationToken)
        {
           var totalCount = _blogReadRepository.GetAll(false).Count();
            var blogs = _blogReadRepository.GetAll(false).Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.ImageUrl,
                p.CreatedTime,
                p.UpdatedTime
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
              
            };  
        }
    }
}
