using System.Threading.Task;
using Microsoft.AspNetCore.SignalR;

namespace Signal.AspNetCore.SignalR
{
    public public class MessageHub : Hub
    {
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage",message);
        }
    }
}