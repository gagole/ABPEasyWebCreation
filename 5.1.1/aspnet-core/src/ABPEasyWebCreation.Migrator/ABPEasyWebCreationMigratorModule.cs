using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPEasyWebCreation.Configuration;
using ABPEasyWebCreation.EntityFrameworkCore;
using ABPEasyWebCreation.Migrator.DependencyInjection;

namespace ABPEasyWebCreation.Migrator
{
    [DependsOn(typeof(ABPEasyWebCreationEntityFrameworkModule))]
    public class ABPEasyWebCreationMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABPEasyWebCreationMigratorModule(ABPEasyWebCreationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ABPEasyWebCreationMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ABPEasyWebCreationConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPEasyWebCreationMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
