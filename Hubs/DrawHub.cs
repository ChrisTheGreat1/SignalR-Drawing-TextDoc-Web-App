using Microsoft.AspNetCore.SignalR;
using static DrawingApp.Hubs.DrawingObjects;

namespace DrawingApp.Hubs
{
    public class DrawHub : Hub
    {
        public async Task DrawStroke(StrokeTool strokeTool)
        {
            await Clients.Others.SendAsync("drawStroke", strokeTool);
        }

        public async Task InitializeNewStroke(InitializeNewStrokeObject newStrokeObject)
        {
            await Clients.Others.SendAsync("initializeNewStroke", newStrokeObject);
        }

        // TODO: delete?
        public async Task StartNewStroke(StrokeStartingCoordinates startingCoordinates)
        {
            await Clients.Others.SendAsync("startNewStroke", startingCoordinates);
        }

        public async Task DrawCircle(Circle circle)
        {
            await Clients.Others.SendAsync("drawCircle", circle);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task Send(string message)
        {
            await Clients.All.SendAsync("newMessage", message);
        }
    }
}
