using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LAB.Authorization;

namespace LAB
{
    [DependsOn(
        typeof(LABCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LABApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LABAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LABApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
