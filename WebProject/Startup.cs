using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using WebProject.Migrations;
using WebProject.Models;

[assembly: OwinStartupAttribute(typeof(WebProject.Startup))]
namespace WebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Configuration>());
                ConfigureAuth(app);
        }
    }
}
