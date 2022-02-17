using AquaGarden.Models;
using Microsoft.EntityFrameworkCore;

namespace AquaGarden.Data
{
    public class AquaDbContext:DbContext
    {
        public AquaDbContext(DbContextOptions<AquaDbContext> options) : base(options)
        {
        }


        public DbSet<Aqua> Aquas { get; set; }
    }
}
