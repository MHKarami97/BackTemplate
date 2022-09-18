using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BackTemplate.Authorization;

namespace BackTemplate
{
    [DependsOn(
        typeof(BackTemplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BackTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BackTemplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BackTemplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
