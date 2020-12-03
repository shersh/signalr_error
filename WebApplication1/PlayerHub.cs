using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class PlayerHub : Hub
    {
        private readonly ILogger<PlayerHub> _logger;

        public PlayerHub(ILogger<PlayerHub> logger)
        {
            _logger = logger;
        }

        public override Task OnConnectedAsync()
        {
            _logger.LogInformation("Connected");
            return base.OnConnectedAsync();
        }
    }
}
