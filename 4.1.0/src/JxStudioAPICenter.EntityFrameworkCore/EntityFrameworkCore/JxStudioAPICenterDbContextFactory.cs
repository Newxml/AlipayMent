using JxStudioAPICenter.Configuration;
using JxStudioAPICenter.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace JxStudioAPICenter.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class JxStudioAPICenterDbContextFactory : IDesignTimeDbContextFactory<JxStudioAPICenterDbContext>
    {
        public JxStudioAPICenterDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JxStudioAPICenterDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(JxStudioAPICenterConsts.ConnectionStringName)
            );

            return new JxStudioAPICenterDbContext(builder.Options);
        }
    }
}