using Microsoft.AspNet.SignalR;

namespace AspSignalRTest
{
    public class SignalRHub : Hub
    {
        public void ButtonPress(int number)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
            context.Clients.All.buttonPressed(number);
        }
    }
}