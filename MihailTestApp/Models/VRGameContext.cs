using Microsoft.EntityFrameworkCore;

namespace MihailTestApp.Models
{
    public class VRGameContext : DbContext
    {
        public DbSet<VRGame> VRGames { get; set; }

        public VRGameContext(DbContextOptions<VRGameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
