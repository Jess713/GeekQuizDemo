using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeekQuizDemo.Startup))]
namespace GeekQuizDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
