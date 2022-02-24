using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var lause = "owo owo";//lause, mis on vaja testida - kas seal on palindromid
        lause = lause.Replace(" ", "").ToLower();
        Console.WriteLine(lause);
        var t = new string(lause.Reverse().ToArray());
        Console.WriteLine(t == lause ? "See on palindrom" : "See ei ole palindrom");
        Console.ReadLine();
        }
    }
}
