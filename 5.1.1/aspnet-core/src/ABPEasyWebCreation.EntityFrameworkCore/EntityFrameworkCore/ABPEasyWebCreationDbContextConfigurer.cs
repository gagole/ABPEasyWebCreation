using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPEasyWebCreation.EntityFrameworkCore
{
    public static class ABPEasyWebCreationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPEasyWebCreationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPEasyWebCreationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
