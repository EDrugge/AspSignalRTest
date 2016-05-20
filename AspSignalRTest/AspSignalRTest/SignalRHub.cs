using Microsoft.AspNet.SignalR;

namespace AspSignalRTest
{
    public class SignalRHub : Hub
    {
        public void TextUpdated(string text)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
            context.Clients.All.textUpdated(text);
        }
    }
}