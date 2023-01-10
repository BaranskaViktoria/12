using System.Text.RegularExpressions;
using System.Text;

class _4
{
    static void Main()
    {
        var pattern = @"<a.{0,}?(href=?(['|""]?).+?\2).{0,}?>(.+?)<\/a>";

        string action = "<ul>\n    <li>\n\t<a href=\"http://softuni.com\">Sofftuni!</a>\n    </li>\n</ul>";

        Regex regex = new(pattern);
        string cleanString = regex.Replace(action, "[URL href=$1>$3[/URL]");

        Console.WriteLine(cleanString);


        Console.ReadKey();
    }
}