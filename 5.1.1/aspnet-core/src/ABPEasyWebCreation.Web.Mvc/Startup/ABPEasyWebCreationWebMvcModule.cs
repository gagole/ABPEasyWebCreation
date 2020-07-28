using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPEasyWebCreation.Configuration;

namespace ABPEasyWebCreation.Web.Startup
{
    [DependsOn(typeof(ABPEasyWebCreationWebCoreModule))]
    public class ABPEasyWebCreationWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPEasyWebCreationWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ABPEasyWebCreationNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPEasyWebCreationWebMvcModule).GetAssembly());
        }
    }
}
