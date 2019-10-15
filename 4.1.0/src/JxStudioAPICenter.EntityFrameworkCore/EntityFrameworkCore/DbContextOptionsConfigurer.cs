using Microsoft.EntityFrameworkCore;

namespace JxStudioAPICenter.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<JxStudioAPICenterDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for JxStudioAPICenterDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
