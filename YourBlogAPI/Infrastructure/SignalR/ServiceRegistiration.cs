using Application.Hubs;
using Microsoft.Extensions.DependencyInjection;
using SignalR.HubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR
{
    public static class ServiceRegistiration 
    {
        public static void AddSignalRService(this IServiceCollection services)
        {
            services.AddSignalR();
            services.AddTransient<IBlogHubService, BlogHubService>();
        }   
    }
}
