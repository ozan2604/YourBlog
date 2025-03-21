using Application.Hubs;
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
        private readonly IBlogHubService _productHubService;

        public CreateBlogCommandHandler(IBlogWriteRepository writeRepository, IBlogHubService productHubService)
        {
            _writeRepository = writeRepository;
            _productHubService = productHubService;
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

            await _productHubService.BlogAddedMessageAsync($"{request.Title} adında blog eklenmiştir");

            return new CreateBlogCommandResponse()
            {
                Message = "Blog Created Successfully"
            };
        }
    }
}
