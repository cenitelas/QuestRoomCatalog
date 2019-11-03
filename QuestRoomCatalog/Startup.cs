using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestRoomCatalog.Startup))]
namespace QuestRoomCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
