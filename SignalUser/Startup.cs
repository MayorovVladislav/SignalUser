using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalUser.Startup))]
namespace SignalUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
