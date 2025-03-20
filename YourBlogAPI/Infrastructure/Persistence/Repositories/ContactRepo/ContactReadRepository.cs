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
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(YourBlogDbContext context) : base(context)
        { }
    }
}
