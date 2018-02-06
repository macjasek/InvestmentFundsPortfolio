using System.Linq;

namespace InvestmentFundsPortfolio.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InvestmentsDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any Funds

            if (context.Funds.Any())
            {
                return; //DB has been seeded
            }

            var funds = new Fund[]
            {
                new Fund{Name="Skarbiec Obligacja Instrumentów Dłużnych (Skarbiec FIO)",
                         Url=@"https://www.bankier.pl/fundusze/notowania/SKR05",
                         Price=313.75m},
                new Fund
                {
                    Name = "Investor Nowych Technologii (Investor SFIO)",
                    Url = @"https://www.bankier.pl/fundusze/notowania/INV36",
                    Price=117.68m
                },
                new Fund
                {
                    Name = "",
                    Url = @"",
                    Price=0.0m
                }
            };

        }
    }
}
