using System.Text.RegularExpressions;
using System.Text;

class _3
{
    static void Main()
    {
        string input = Console.ReadLine();
        //ЗАМІНЮЄ РЯДКИ 
        // 1+ ЯКЩО ПОВТОРЕНЬ БІЛЬШЕ 1
        var result = Regex.Replace(input, @"([A-Za-z])\1+", "$1");

        Console.WriteLine(result);
    }
}