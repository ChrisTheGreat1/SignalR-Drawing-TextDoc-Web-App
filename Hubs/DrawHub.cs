using Microsoft.AspNetCore.SignalR;
using System.Drawing;
using static DrawingApp.Hubs.DrawingObjects;

namespace DrawingApp.Hubs
{
    public class DrawHub : Hub
    {
        public async Task DrawClientStroke(StrokeTool strokeTool)
        {
            await Clients.Others.SendAsync("drawClientStroke", strokeTool);
        }

        public async Task InitializeNewClientStroke(NewStrokeObject newStrokeObject)
        {
            await Clients.Others.SendAsync("initializeNewClientStroke", newStrokeObject);
        }

        public async Task DrawClientCircle(Circle circle)
        {
            await Clients.Others.SendAsync("drawClientCircle", circle);
        }

        public async Task DrawClientRectangle(DrawingObjects.Rectangle rectangle)
        {
            await Clients.Others.SendAsync("drawClientRectangle", rectangle);
        }

        public async Task DrawClientTriangle(Triangle triangle)
        {
            await Clients.Others.SendAsync("drawClientTriangle", triangle);
        }

        public async Task ClearClientCanvas()
        {
            await Clients.Others.SendAsync("clearClientCanvas");
        }

        public async Task UpdateText(string textContents)
        {
            await Clients.All.SendAsync("updateText", textContents);
        }
    }
}
