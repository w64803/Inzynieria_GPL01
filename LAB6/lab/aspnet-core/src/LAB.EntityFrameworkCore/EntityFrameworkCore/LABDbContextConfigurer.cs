using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LAB.EntityFrameworkCore
{
    public static class LABDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LABDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LABDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
