using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JxStudioAPICenter.EntityFrameworkCore
{
    public class JxStudioAPICenterDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public JxStudioAPICenterDbContext(DbContextOptions<JxStudioAPICenterDbContext> options) 
            : base(options)
        {

        }
    }
}
