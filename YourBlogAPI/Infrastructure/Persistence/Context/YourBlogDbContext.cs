using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class YourBlogDbContext : DbContext
    {
        public YourBlogDbContext(DbContextOptions options) : base(options) {  }

        DbSet<Service> Services { get; set; }
        DbSet<About> Abouts { get; set; }
        DbSet<Blog> Blogs { get; set; } 
        DbSet<Contact> Contacts { get; set; }   
        DbSet<Gallery> galleries { get; set; }

        //Inspector mekanizmasıdır. Base entityde bulunan fix şeyler boş olsa da dolu olsada burda doldurulup veritabanına öyle yönlendiriliyor..
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedTime = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedTime = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };


            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
