using Application.Repositories;
using Application.Repositories.BlogRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest, CreateBlogCommandResponse>
    {
        private readonly IBlogWriteRepository _writeRepository;

        public CreateBlogCommandHandler(IBlogWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<CreateBlogCommandResponse> Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.AddAsync(new Blog()
            {
                Title = request.Title,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
            });

            await _writeRepository.SaveAsync();
            return new CreateBlogCommandResponse()
            {
                Message = "Blog Created Successfully"
            };
        }
    }
}
