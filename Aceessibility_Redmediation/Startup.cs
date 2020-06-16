using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aceessibility_Redmediation.Startup))]
namespace Aceessibility_Redmediation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
