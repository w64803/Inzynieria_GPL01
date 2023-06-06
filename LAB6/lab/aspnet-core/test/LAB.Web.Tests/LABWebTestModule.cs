using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LAB.EntityFrameworkCore;
using LAB.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LAB.Web.Tests
{
    [DependsOn(
        typeof(LABWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LABWebTestModule : AbpModule
    {
        public LABWebTestModule(LABEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LABWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LABWebMvcModule).Assembly);
        }
    }
}