using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hubs
{
    public interface IBlogHubService
    {
        Task BlogAddedMessageAsync(string message);
    }
}
