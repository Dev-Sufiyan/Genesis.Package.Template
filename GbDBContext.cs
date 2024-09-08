using Microsoft.EntityFrameworkCore;


namespace Genie.Counter.DBContext;
public class GbDbContext : DbContext
{
    public GbDbContext(DbContextOptions<GbDbContext> options) : base(options) { }

}

