using Application.Repositories.BlogRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Queries.BlogQueries.GetByIdBlog
{
    public class GetByIdBlogQueryHandler : IRequestHandler<GetByIdBlogQueryRequest, GetByIdBlogQueryResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;

        public GetByIdBlogQueryHandler(IBlogReadRepository blogReadRepository)
        {
            _blogReadRepository = blogReadRepository;
        }

        public async Task<GetByIdBlogQueryResponse> Handle(GetByIdBlogQueryRequest request, CancellationToken cancellationToken)
        {
            Blog blog = await _blogReadRepository.GetByIdAsync(request.Id , false);
            return new()
            {
                Id = blog.Id,
                Title = blog.Title,
                Description = blog.Description,
                ImageUrl = blog.ImageUrl,
                CreatedTime = blog.CreatedTime,
                UpdatedTime = blog.UpdatedTime
            };
        }
    }
}
