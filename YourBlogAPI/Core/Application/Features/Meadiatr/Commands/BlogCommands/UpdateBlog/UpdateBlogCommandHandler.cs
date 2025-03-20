
using Application.Repositories.BlogRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest, UpdateBlogCommandResponse>
    {
        private readonly IBlogReadRepository _readRepository;
        private readonly IBlogWriteRepository _writeRepository;

        public UpdateBlogCommandHandler(IBlogReadRepository readRepository, IBlogWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task<UpdateBlogCommandResponse> Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            Blog blog = await _readRepository.GetByIdAsync(request.Id);    
            blog.Title = request.Title;
            blog.Description = request.Description;
            blog.ImageUrl = request.ImageUrl;
            blog.UpdatedTime = DateTime.Now;

            await _writeRepository.SaveAsync();
            return new();   
        }
    }
}
