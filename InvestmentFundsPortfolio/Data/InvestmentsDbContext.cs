using Microsoft.EntityFrameworkCore;

namespace InvestmentFundsPortfolio.Data
{
    public class InvestmentsDbContext : DbContext
    {
        public InvestmentsDbContext(DbContextOptions<InvestmentsDbContext> options):base(options)
        {
        }

        public DbSet<Fund> Funds { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fund>().ToTable("Fund");
            modelBuilder.Entity<Investor>().ToTable("Investor");
            modelBuilder.Entity<Portfolio>().ToTable("Portfolio");
        }
    }
}
