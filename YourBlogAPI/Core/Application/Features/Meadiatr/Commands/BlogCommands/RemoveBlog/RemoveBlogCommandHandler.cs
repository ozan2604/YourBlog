using Application.Repositories.BlogRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Meadiatr.Commands.BlogCommands.RemoveBlog
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommandRequest, RemoveBlogCommandResponse>
    {

        public readonly IBlogWriteRepository _repository;

        public RemoveBlogCommandHandler(IBlogWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<RemoveBlogCommandResponse> Handle(RemoveBlogCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);  
            await _repository.SaveAsync();
            return new();
          //  return new RemoveBlogCommandResponse();
        }
    }
}
