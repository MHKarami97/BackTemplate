using Abp.Application.Services;
using BackTemplate.MultiTenancy.Dto;

namespace BackTemplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

