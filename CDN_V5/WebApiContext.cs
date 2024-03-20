using Microsoft.EntityFrameworkCore;
using CDN_V5;

namespace CDN_V5
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }
        public DbSet<CDN_V5.Users> Users { get; set; } = default!;
    }
}
