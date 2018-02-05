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

            Console.WriteLine(node.InnerText);

        }
    }
}
