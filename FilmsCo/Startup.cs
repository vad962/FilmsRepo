using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmsCo.Startup))]
namespace FilmsCo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
