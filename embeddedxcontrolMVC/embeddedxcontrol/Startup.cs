using embeddedxcontrol.Migrations;
using embeddedxcontrol.Models;
using embeddedxcontrol.Repo;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(embeddedxcontrol.Startup))]
namespace embeddedxcontrol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Add admin user to DB
            //var _context = new ApplicationDbContext();
            //var _config = new Configuration();
            //_config.Seed2(_context);

            ConfigureAuth(app);
        }
    }
}
