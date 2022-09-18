using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BackTemplate.EntityFrameworkCore
{
    public static class BackTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BackTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BackTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
