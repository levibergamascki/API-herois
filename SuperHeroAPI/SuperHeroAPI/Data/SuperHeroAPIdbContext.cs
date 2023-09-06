using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Data
{
    public class SuperHeroAPIdbContext : DbContext
    {
        public SuperHeroAPIdbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Identity> Identities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
