using Microsoft.EntityFrameworkCore;

namespace assign.Models
{
    public class ApplicationDbContext: DbContext
    {
        internal readonly object Transaction;

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
