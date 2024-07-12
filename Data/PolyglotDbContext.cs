using Microsoft.EntityFrameworkCore;
using polyglot.Models;

namespace polyglot.Data
{
    public class PolyglotDbContext : DbContext
    {
        public PolyglotDbContext(DbContextOptions<PolyglotDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Word>();
        }

        public DbSet<Word> Words { get; set; }
    }
}
