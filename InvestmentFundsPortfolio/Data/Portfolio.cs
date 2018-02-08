namespace InvestmentFundsPortfolio.Data
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public int FundID { get; set; }
        public int InvestorID { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal StopLoss { get; set; }

        public Fund Fund { get; set; }
        public Investor Investor { get; set; }
    }
}
