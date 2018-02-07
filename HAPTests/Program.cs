using HtmlAgilityPack;
using System;

namespace HAPTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // var html = @"https://www.bankier.pl/fundusze/notowania/UNI34";

           var html = @"https://www.analizy.pl/fundusze/fundusze-inwestycyjne/profil-funduszu/OPT04/89th-Avenue-Fund-No-1-FIZ.html";
            html = @"https://www.analizy.pl/fundusze/fundusze-zagraniczne/profil-funduszu/BGF054_A2_USD/BlackRock-GF-World-Healthscience-A2-%28USD%29.html";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            //var nodes = htmlDoc.DocumentNode.SelectNodes("//script");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//div[2]/div[2]/script[2]");

            Console.WriteLine(node.InnerText);

        }
    }
}
