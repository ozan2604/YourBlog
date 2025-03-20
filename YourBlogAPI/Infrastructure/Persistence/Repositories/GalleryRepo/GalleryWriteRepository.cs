using Application.Repositories.GalleryRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.GalleryRepo
{

    public class GalleryWriteRepository : WriteRepository<Gallery>, IGalleryWriteRepository
    {
        public GalleryWriteRepository(YourBlogDbContext context) : base(context)
        {

        }
    }
    
}
