using Microsoft.EntityFrameworkCore;
using Valaki.Domain.Entities;

namespace Valaki.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<KiteSpot> KiteSpots { get; set; }
    }
}
