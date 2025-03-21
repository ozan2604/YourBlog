﻿using Application.Hubs;
using Microsoft.AspNetCore.SignalR;
using SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.HubServices
{
    public class BlogHubService : IBlogHubService
    {

        readonly IHubContext<BlogHub> _hubContext;

        public BlogHubService(IHubContext<BlogHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task BlogAddedMessageAsync(string message)
        {
           
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionName.BlogAddedMessage , message);


            //await _hubContext.Clients.All.SendAsync("RecieveBlogAddedMessage", message);
        }
    }
}
