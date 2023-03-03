using DrawingApp.Models;
using Microsoft.AspNetCore.SignalR;
using System.Drawing;

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

        //public async Task NewStroke(DrawingPoint start, DrawingPoint end)
        //{
        //    await Clients.Others.SendAsync("newStroke", start, end);
        //}

        //public async Task NewStroke(int x, int y)
        //{
        //    await Clients.Others.SendAsync("newStroke", x, y);
        //}

        public async Task NewStroke(int currentX, int currentY, int previousX, int previousY)
        {
            await Clients.Others.SendAsync("newStroke", currentX, currentY, previousX, previousY);
        }
    }
}
