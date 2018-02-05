using System.Collections.Generic;

namespace InvestmentFundsPortfolio.Data
{
    public class Investor
    {
        public int ID { get; set; }
        public string Nickname { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
