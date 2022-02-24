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
            //random matrix
        int neg = 0;
        int pos = 0;
        Random random = new Random();
        int arv = random.Next(2, 11);
        int[,] Matrix = new int[arv, arv];
        int rand;
        for (int i = 0; i < arv; i++)
        {
            for (int j = 0; j < arv; j++)
            {
                rand = random.Next(0, 100);
                Matrix[i, j] = rand;
            }
        }
        //ekraanile
        for (int i = 0; i < arv; i++)
        {
            for (int j = 0; j < arv; j++)
            {
                Console.Write(Matrix[i, j] + "\t");
            }
            Console.WriteLine(neg);
        }

        Console.ReadKey();
        Console.ReadLine();
        }
    }
}
