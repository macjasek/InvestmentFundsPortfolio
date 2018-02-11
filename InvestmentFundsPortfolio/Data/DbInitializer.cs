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
                         Url=@"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/notowania/SKR05/Skarbiec-Obligacja-Instrumentow-Dluznych-%28Skarbiec-FIO%29.html",
                         Price=313.76m},
                new Fund
                {
                    Name = "Investor Nowych Technologii (Investor SFIO)",
                    Url = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/notowania/INV36/Investor-Nowych-Technologii-%28Investor-SFIO%29.html",
                    Price=118.80m
                },
                new Fund
                {
                    Name = "Noble Fund Global Return",
                    Url = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/notowania/NOB07/Noble-Fund-Global-Return-%28Noble-Funds-FIO%29.html",
                    Price=131.78m
                },
                new Fund
                {
                    Name = "Franklin Templeton BRIC Fund (USD)",
                    Url = @"https://www.analizy.pl/fundusze/fundusze-zagraniczne/profil-funduszu/notowania/FTI035_A_USD/Templeton-BRIC-Fund-A-%28Acc%29-%28USD%29.html",
                    Price=19.63m
                },
                new Fund
                {
                    Name = "UniAkcje Małych i Średnich Spółek",
                    Url = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/notowania/UNI19/UniAkcje-Malych-i-Srednich-Spolek-%28UniFundusze-FIO%29.html",
                    Price=109.63m
                },
                new Fund
                {
                    Name = "UniFundusze UniAkcje: Turcja",
                    Url = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/notowania/UNI34/UniAkcje%3A-Turcja-%28UniFundusze-FIO%29.html",
                    Price=67.35m
                }
            };
            foreach (Fund f in funds)
            {
                context.Funds.Add(f);
            }
            context.SaveChanges();

            var portfolios = new Portfolio[]
            {
                new Portfolio {InvestorID = 1, FundID = 1, StartingPrice = 310.18m, MaxPrice = 314.21m, StopLoss = 2.0m},
                new Portfolio {InvestorID = 1, FundID = 2, StartingPrice = 113.47m, MaxPrice = 125.26m, StopLoss = 8.0m},
                new Portfolio {InvestorID = 1, FundID = 3, StartingPrice = 131.25m, MaxPrice = 136.74m, StopLoss = 8.0m},
                new Portfolio {InvestorID = 1, FundID = 4, StartingPrice = 18.34m, MaxPrice = 21.46m, StopLoss = 8.0m},
                new Portfolio {InvestorID = 1, FundID = 5, StartingPrice = 107.38m, MaxPrice = 109.87m, StopLoss = 8.0m},
                new Portfolio {InvestorID = 1, FundID = 6, StartingPrice = 67.23m, MaxPrice = 38.21m, StopLoss = 8.0m}
            };
            foreach (Portfolio p in portfolios)
            {
                context.Portfolios.Add(p);
            }
            context.SaveChanges();

            var investros = new Investor[]
            {
                new Investor {Nickname = "macjasek"}
            };
            foreach (Investor i in investros)
            {
                context.Investors.Add(i);
            }
            context.SaveChanges();
        }
    }
}
