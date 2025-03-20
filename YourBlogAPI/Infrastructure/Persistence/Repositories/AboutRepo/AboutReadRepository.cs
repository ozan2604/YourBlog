using Application.Repositories.AboutRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.AboutRepo
{
    public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
    {
        public AboutReadRepository(YourBlogDbContext context) : base(context)
        {
        }
    }
}
