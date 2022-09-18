using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BackTemplate.EntityFrameworkCore;
using BackTemplate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BackTemplate.Web.Tests
{
    [DependsOn(
        typeof(BackTemplateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BackTemplateWebTestModule : AbpModule
    {
        public BackTemplateWebTestModule(BackTemplateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BackTemplateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BackTemplateWebMvcModule).Assembly);
        }
    }
}