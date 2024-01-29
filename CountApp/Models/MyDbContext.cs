using Microsoft.EntityFrameworkCore;

namespace CountApp.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<RomanNumber> Numbers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Db");
        }

    }
}
