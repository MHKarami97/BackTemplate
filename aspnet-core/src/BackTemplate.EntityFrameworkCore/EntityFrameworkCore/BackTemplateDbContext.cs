using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BackTemplate.Authorization.Roles;
using BackTemplate.Authorization.Users;
using BackTemplate.MultiTenancy;

namespace BackTemplate.EntityFrameworkCore
{
    public class BackTemplateDbContext : AbpZeroDbContext<Tenant, Role, User, BackTemplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BackTemplateDbContext(DbContextOptions<BackTemplateDbContext> options)
            : base(options)
        {
        }
    }
}
