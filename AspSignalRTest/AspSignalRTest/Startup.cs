using System;
using System.Threading;
using System.Threading.Tasks;
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
                while (true)
                {
                    hub.TextUpdated(DateTime.Now.ToString("HH:mm:ss"));
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
