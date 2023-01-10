using System.Text.RegularExpressions;
using System.Text;

class _6
{
    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();

        var regex = Regex.Matches(text, $@"([A-Z][A-Z,a-z,0-9]*(\s?\w*|[,]|[-])*)*(\b({word})\b)((\s?\w*|[,]|[-])*[A-Z,a-z,0-9]*[!,\.,?])", RegexOptions.IgnoreCase);

        foreach (Match match in regex)
        {
            Console.WriteLine(match.Value);
        }
    }
}