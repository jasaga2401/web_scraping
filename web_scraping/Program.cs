using System;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        // Specify the URL of the webpage you want to scrape
        string url = "https://www.bbc.co.uk/news";

        // Create an HtmlWeb instance
        HtmlWeb web = new HtmlWeb();

        // Load the HTML document from the URL
        HtmlDocument doc = web.Load(url);

        // Use XPath or other methods to select specific elements
        // For example, let's extract all the text from h1 tags
        var h1Nodes = doc.DocumentNode.SelectNodes("//div");

        if (h1Nodes != null)
        {
            foreach (var h1Node in h1Nodes)
            {
                Console.WriteLine(h1Node.InnerText);
            }
        }
        else
        {
            Console.WriteLine("No h1 tags found on the page.");
        }
    }
}

