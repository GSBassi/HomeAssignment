using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HomeAssignment.Configuration;
using HomeAssignment.Web;

namespace HomeAssignment.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HomeAssignmentDbContextFactory : IDesignTimeDbContextFactory<HomeAssignmentDbContext>
    {
        public HomeAssignmentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HomeAssignmentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HomeAssignmentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HomeAssignmentConsts.ConnectionStringName));

            return new HomeAssignmentDbContext(builder.Options);
        }
    }
}
