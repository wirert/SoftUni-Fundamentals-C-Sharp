using System;
using System.Text;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder htmlText = new StringBuilder();

            htmlText.AppendLine("<h1>");
            htmlText.AppendLine($"    {Console.ReadLine()}");
            htmlText.AppendLine("</h1>");
            htmlText.AppendLine("<article>");
            htmlText.AppendLine($"    {Console.ReadLine()}");
            htmlText.AppendLine("</article>");

            string comment = null;

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                htmlText.AppendLine("<div>");
                htmlText.AppendLine($"    {comment}");
                htmlText.AppendLine("</div>");
            }

            Console.WriteLine(htmlText);

        }
    }
}
