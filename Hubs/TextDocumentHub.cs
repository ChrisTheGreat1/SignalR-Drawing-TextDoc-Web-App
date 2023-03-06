using Microsoft.AspNetCore.SignalR;
using static DrawingApp.Hubs.DrawingObjects;

namespace DrawingApp.Hubs
{
    public class TextDocumentHub : Hub 
    {
        public async Task UpdateText(string textContents)
        {
            await Clients.All.SendAsync("updateText", textContents);
        }
    }
}
