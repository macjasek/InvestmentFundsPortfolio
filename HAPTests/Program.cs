using HtmlAgilityPack;
using System;
using System.Globalization;

namespace HAPTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // var html = @"https://www.bankier.pl/fundusze/notowania/UNI34";

           var html = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/OPT04/89th-Avenue-Fund-No-1-FIZ.html";
            html = @"https://www.analizy.pl/fundusze/fundusze-zagraniczne/profil-funduszu/notowania/BGF054_A2_USD/BlackRock-GF-World-Healthscience-A2-%28USD%29.html";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var nodes = htmlDoc.DocumentNode.SelectNodes("//script");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//div[1]/div[2]/script[2]");

            var price = GetPrice(node.InnerText);

            Console.WriteLine(price.ToString());




        }

        static decimal GetPrice(string text)
        {
            var texts = text.Split(' ');
            

            text = texts[48].Trim();

            var value1Index = text.LastIndexOf("value1");

            var tempText = text.Substring(value1Index,18);
            texts = tempText.Split('"');

            tempText = texts[2].Trim();

            return decimal.Parse(tempText, new CultureInfo("en-US"));
        }
    }
}
