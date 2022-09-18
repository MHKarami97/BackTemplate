using System.Threading.Tasks;
using BackTemplate.Configuration.Dto;

namespace BackTemplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
