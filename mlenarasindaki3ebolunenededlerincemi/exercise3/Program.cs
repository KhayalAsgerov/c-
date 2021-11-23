using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlenarasindaki3ebolunenededlerincemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, sum=0;
            Console.WriteLine("m ededini girin");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n ededini girin");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        git:
            if (m < n)
            {
                if (m % 3 == 0)
                {
                    sum = sum + m;
                    m++;
                    goto git;
                }
                else
                {
                    m++;
                    goto git;
                }
            }
            else
            {
                Console.WriteLine(m + " ile " + n + " arasindaki 3-e bolunen edelerin cemi =  " + sum);
            }
        Console.ReadLine();
        }
    }
}
