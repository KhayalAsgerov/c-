using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertx_y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X-in deyerni girin - " );
            string x = Console.ReadLine();
            int m = Convert.ToInt32(x);
            Console.WriteLine("Y-in deyerini girin - ");
            string y = Console.ReadLine();
            int n = Convert.ToInt32(y);
            int sum = m + n;
            Console.WriteLine("GIRDIYINIZ EDEDLERIN CEMI = " + sum);
            

           Console.ReadLine();

        }
    }
}
