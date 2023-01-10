using System.Text.RegularExpressions;
using System.Text;

class _2
{
    static void Main()
    {
        var sb = new StringBuilder();
        var input = Console.ReadLine();

        while (input != "end")
        {
            //додає рядкове представлення input  до цього екземпляра.
            sb.Append($"{input}{Environment.NewLine}");
            input = Console.ReadLine();
        }
        var regex = new Regex(@"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b");
        //{4}-4 цифри

        //Набір успішних збігів
        MatchCollection matches = regex.Matches(sb.ToString());
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}