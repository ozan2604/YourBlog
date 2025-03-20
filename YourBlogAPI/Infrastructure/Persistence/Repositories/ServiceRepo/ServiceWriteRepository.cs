using Application.Repositories.ServiceRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ServiceRepo
{
    public class ServiceWriteRepository : WriteRepository<Service>, IServiceWriteRepository
    {
        public ServiceWriteRepository(YourBlogDbContext context) : base(context)
        { }
    }
}
