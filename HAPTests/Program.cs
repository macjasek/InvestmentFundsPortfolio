using HtmlAgilityPack;
using System;

namespace HAPTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"https://www.bankier.pl/fundusze/notowania/UNI34";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//tr[1]/td[2]");

            //var nodes = htmlDoc.DocumentNode.SelectNodes("//td");

            //foreach (var singleNode in nodes)
            //{
            //    if (singleNode.HasClass("textBold"))
            //    {
            //        Console.WriteLine(singleNode.InnerText.Trim());
            //    }

            //}
            Console.WriteLine(node.InnerText);

        }
    }
}
