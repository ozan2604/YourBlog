using Application.Repositories.ContactRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ContactRepo
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(YourBlogDbContext context) : base(context)
        { }
    }
}
