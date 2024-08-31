using Microsoft.EntityFrameworkCore;

namespace coolez.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<coolezDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for coolezDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
