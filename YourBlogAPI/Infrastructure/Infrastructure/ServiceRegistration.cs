using Application.Abstractions.Token;
using Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrustructureService(this IServiceCollection services)
        {

            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
