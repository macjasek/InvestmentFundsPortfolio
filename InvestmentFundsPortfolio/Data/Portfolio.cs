namespace InvestmentFundsPortfolio.Data
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public int FundID { get; set; }
        public int InvestorID { get; set; }

        public Fund Fund { get; set; }
        public Investor Investor { get; set; }
    }
}
