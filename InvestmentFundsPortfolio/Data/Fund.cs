using System.Collections.Generic;

namespace InvestmentFundsPortfolio.Data
{
    public class Fund
    {
        public int FundID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
