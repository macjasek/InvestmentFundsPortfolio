using InvestmentFundsPortfolio.Data;
using InvestmentFundsPortfolio.Data.ViewModels;
using InvestmentFundsPortfolio.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentFundsPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InvestmentsDbContext _db;

        public IndexModel(InvestmentsDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IList<Fund> Funds { get; set; }
        [BindProperty]
        public IList<PortfolioFunds> PortfolioFunds { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {

            PortfolioFunds = await _db.Portfolios
                 .Select(p => new PortfolioFunds {
                     FundID = p.FundID,
                     Name = p.Fund.Name,
                     StartingPrice = p.StartingPrice,
                     Price = p.Fund.Price,
                     Url = p.Fund.Url
                 }).ToListAsync();

           

            //Funds = await _db.Funds.AsNoTracking().ToListAsync();

            //string query = "Select Fund.Name, Portfolio.StartingPrice " +
            //               "From Fund, Portfolio " +
            //               "Where Fund.FundID = Portfolio.FundID";

            //var portfolioFunds = await _db.Funds.FromSql(query).ToListAsync();

            foreach (PortfolioFunds p in PortfolioFunds)
            {
                p.Price = Quotations.GetPrice(p.Url);
            }

            return Page();
        }
    }
}
