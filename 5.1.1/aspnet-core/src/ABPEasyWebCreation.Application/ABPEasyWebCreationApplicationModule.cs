using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPEasyWebCreation.Authorization;

namespace ABPEasyWebCreation
{
    [DependsOn(
        typeof(ABPEasyWebCreationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPEasyWebCreationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPEasyWebCreationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPEasyWebCreationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
