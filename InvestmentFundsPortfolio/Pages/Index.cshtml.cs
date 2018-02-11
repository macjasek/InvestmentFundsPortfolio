using InvestmentFundsPortfolio.Data;
using InvestmentFundsPortfolio.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<IActionResult> OnGetAsync()
        {
            Funds = await _db.Funds.AsNoTracking().ToListAsync();
            foreach (Fund f in Funds)
            {
                f.Price = Quotations.GetPrice(f.Url);
            }

            return Page();
        }
    }
}
