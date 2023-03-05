using Microsoft.AspNetCore.SignalR;

namespace DrawingApp.Hubs
{
    public class DrawHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task Send(string message)
        {
            await Clients.All.SendAsync("newMessage", message);
        }

        public async Task NewStroke(DrawingCoordinates coordinates)
        {
            await Clients.Others.SendAsync("newStroke", coordinates);
        }
    }
}
