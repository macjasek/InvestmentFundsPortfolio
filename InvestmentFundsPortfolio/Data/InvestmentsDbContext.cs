using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            modelBuilder.Entity<Investor>().ToTable("Investors");
            modelBuilder.Entity<Portfolio>().ToTable("Portfolio");
        }
    }
}
