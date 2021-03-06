using Microsoft.EntityFrameworkCore;

namespace AngularMate.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Models.Value> Values { get; set; }
    }
}