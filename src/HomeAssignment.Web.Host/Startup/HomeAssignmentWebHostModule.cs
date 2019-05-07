using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeAssignment.Configuration;

namespace HomeAssignment.Web.Host.Startup
{
    [DependsOn(
       typeof(HomeAssignmentWebCoreModule))]
    public class HomeAssignmentWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HomeAssignmentWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HomeAssignmentWebHostModule).GetAssembly());
        }
    }
}
