using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_den_n_e_qederolanededlerincemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M-den N-e qeder olan ededlerin cemini tapmaqucun M-ededini girin");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N-ededini girin");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = m+1; i < n; i++)
            {
               sum += i;
              
            }
            Console.WriteLine(m+" ile "+n+" arasindaki ededlerin cemi = " + sum);
            
            Console.ReadLine(); 

        }
    }
}
