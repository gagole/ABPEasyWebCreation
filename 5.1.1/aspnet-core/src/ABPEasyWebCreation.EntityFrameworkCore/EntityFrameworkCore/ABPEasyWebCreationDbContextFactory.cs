using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPEasyWebCreation.Configuration;
using ABPEasyWebCreation.Web;

namespace ABPEasyWebCreation.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPEasyWebCreationDbContextFactory : IDesignTimeDbContextFactory<ABPEasyWebCreationDbContext>
    {
        public ABPEasyWebCreationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPEasyWebCreationDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPEasyWebCreationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPEasyWebCreationConsts.ConnectionStringName));

            return new ABPEasyWebCreationDbContext(builder.Options);
        }
    }
}
