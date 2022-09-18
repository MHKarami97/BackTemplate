using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BackTemplate.Configuration;

namespace BackTemplate.Web.Host.Startup
{
    [DependsOn(
       typeof(BackTemplateWebCoreModule))]
    public class BackTemplateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BackTemplateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BackTemplateWebHostModule).GetAssembly());
        }
    }
}
