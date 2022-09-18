using System.Threading.Tasks;
using Abp.Application.Services;
using BackTemplate.Sessions.Dto;

namespace BackTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
