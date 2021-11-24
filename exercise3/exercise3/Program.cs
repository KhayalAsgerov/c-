using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m1, n, sum=0;
            Console.WriteLine("M ededini daxil edin");
            m1=Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int m = m1 + 0;
            while ( m < n)
            {
                sum = sum + m;
                
                m++;

            }
            Console.WriteLine(m1 + " ile " + n + " arasindaki ededlerin cemi = " + (sum-m1));
            Console.ReadLine();
        }
    }
}
