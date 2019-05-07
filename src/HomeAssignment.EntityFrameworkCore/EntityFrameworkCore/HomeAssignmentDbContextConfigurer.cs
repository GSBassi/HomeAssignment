using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HomeAssignment.EntityFrameworkCore
{
    public static class HomeAssignmentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HomeAssignmentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HomeAssignmentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
