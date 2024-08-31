using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace coolez.EntityFrameworkCore
{
    public class coolezDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public coolezDbContext(DbContextOptions<coolezDbContext> options) 
            : base(options)
        {

        }
    }
}
