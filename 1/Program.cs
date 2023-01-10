using System.Text.RegularExpressions;
using System.Text;
class _1
{
    static void Main()
    {
        var sb = new StringBuilder();
        var input = Console.ReadLine();

        while (input != "end")
        {
            sb.Append($"{input}{Environment.NewLine}");
            input = Console.ReadLine();
        }

        var regex = new Regex(@"^[A-Z][a-z]+\s[A-Z][a-z]+");
        //\s пробіл
        //* більше букв маленькі
        var matches = regex.Matches(sb.ToString());//повертає параметр який використовувався для виразу

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }

    }
}