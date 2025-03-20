using Application.Repositories.BlogRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.BlogRepo
{
    public class BlogWriteRepository : WriteRepository<Blog>, IBlogWriteRepository
    {
        public BlogWriteRepository(YourBlogDbContext context) : base(context)
        { }
    }
}
