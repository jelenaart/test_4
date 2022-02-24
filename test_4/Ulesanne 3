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
        List<string> sonad = new List<string>() { "Naidis", "Sona", "Veel", "Midagi", "Koer", "Arst", "Veeeeel" };
        Console.WriteLine("Palun kirjutage mida te soovite ümber pöörata");
        IEnumerable<string> jarjekord = from i in sonad
                                    orderby i.Substring(0, 1)
                                    select i;
        foreach (string j in jarjekord)
            Console.WriteLine(j);
        string lause = Console.ReadLine();
        char[] sReverse = lause.ToCharArray();
        Array.Reverse(sReverse);
        lause = new string(sReverse);
        Console.WriteLine(lause);
        Console.ReadLine();
        }
    }
}
