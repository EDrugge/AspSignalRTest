using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspSignalRTest.Startup))]

namespace AspSignalRTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            var hub = new SignalRHub();

            Task.Run(() =>
            {
                var i = 0;
                while (true)
                {
                    hub.ButtonPress(i++);
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
