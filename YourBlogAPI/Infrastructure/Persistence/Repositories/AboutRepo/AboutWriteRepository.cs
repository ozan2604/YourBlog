using Application.Repositories;
using Application.Repositories.AboutRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.AboutRepo
{
    public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
    {
        public AboutWriteRepository(YourBlogDbContext context) : base(context)
        {
        }
    }
}
