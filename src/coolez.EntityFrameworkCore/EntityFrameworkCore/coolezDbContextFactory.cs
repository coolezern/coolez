using coolez.Configuration;
using coolez.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace coolez.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class coolezDbContextFactory : IDesignTimeDbContextFactory<coolezDbContext>
    {
        public coolezDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<coolezDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(coolezConsts.ConnectionStringName)
            );

            return new coolezDbContext(builder.Options);
        }
    }
}