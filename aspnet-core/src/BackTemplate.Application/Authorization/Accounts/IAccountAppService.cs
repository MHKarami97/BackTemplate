using System.Threading.Tasks;
using Abp.Application.Services;
using BackTemplate.Authorization.Accounts.Dto;

namespace BackTemplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
