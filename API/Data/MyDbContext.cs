using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
