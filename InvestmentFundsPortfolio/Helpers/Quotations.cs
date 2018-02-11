using HtmlAgilityPack;
using System.Globalization;

namespace InvestmentFundsPortfolio.Helpers
{
    public class Quotations
    {
        public static decimal GetPrice(string url)
        {
            var quotationsData = ScrapeQuotationData(url);
            var price = PriceFromQuotationsData(quotationsData);

            return price;
        }

        private static string ScrapeQuotationData(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            var node = htmlDoc.DocumentNode.SelectSingleNode("//div[1]/div[2]/script[2]");

            return node.InnerText;
        }

        private static decimal PriceFromQuotationsData(string quotationsData)
        {
            var texts = quotationsData.Split(' ');
            var text = texts[48];
            var value1Index = text.LastIndexOf("value1");
            text = text.Substring(value1Index, 18);
            texts = text.Split('"');
            text = texts[2].Trim();

            return decimal.Parse(text, new CultureInfo("en-US"));
        }
    }
}
