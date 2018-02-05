using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvestmentFundsPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Price { get; set; }
        public string Name { get; set; }

        public void OnGet()
        {

            var html = @"https://www.bankier.pl/fundusze/notowania/SKR05";
            html = @"https://www.bankier.pl/fundusze/notowania/QRS17";
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//tr[1]/td[2]");

            Price = node.InnerText.Trim().Split('&')[0];

            node = htmlDoc.DocumentNode.SelectSingleNode("//div/h1");

            Name = node.InnerText;

        }
    }
}
