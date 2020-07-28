﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPEasyWebCreation.Configuration;

namespace ABPEasyWebCreation.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPEasyWebCreationWebCoreModule))]
    public class ABPEasyWebCreationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPEasyWebCreationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPEasyWebCreationWebHostModule).GetAssembly());
        }
    }
}
