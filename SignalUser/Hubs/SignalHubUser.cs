using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalUser.Models;

namespace SignalUser.Hubs
{
    public class MessageHubUser : Hub
    {
        public void Send(string message)
        {
            Clients.All.messagesend(message);
        }
    }
}