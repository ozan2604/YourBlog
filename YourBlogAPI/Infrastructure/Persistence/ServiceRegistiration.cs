using Application.Repositories.AboutRepositories;
using Application.Repositories.BlogRepositories;
using Application.Repositories.ContactRepositories;
using Application.Repositories.GalleryRepositories;
using Application.Repositories.ServiceRepositories;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories.AboutRepo;
using Persistence.Repositories.BlogRepo;
using Persistence.Repositories.ContactRepo;
using Persistence.Repositories.GalleryRepo;
using Persistence.Repositories.ServiceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<YourBlogDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<YourBlogDbContext>();

            services.AddScoped<IServiceWriteRepository, ServiceWriteRepository>();
            services.AddScoped<IServiceReadRepository, ServiceReadRepository>();

            services.AddScoped<IBlogWriteRepository, BlogWriteRepository>();
            services.AddScoped<IBlogReadRepository, BlogReadRepository>();

            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();

            services.AddScoped<IGalleryReadRepository, GalleryReadRepository>();
            services.AddScoped<IGalleryWriteRepository, GalleryWriteRepository>();

            services.AddScoped<IAboutReadRepository, AboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();


        }       
    }
}
