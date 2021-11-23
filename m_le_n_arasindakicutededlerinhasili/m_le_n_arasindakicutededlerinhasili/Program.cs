using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_le_n_arasindakicutededlerinhasili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M-le N-arasindaki cut ededlerin hasilin tapmaq ucun m ededini girin");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n ededini girin");
            int n = Convert.ToInt32(Console.ReadLine());
            int hasil =1;
            for (int i=m+1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    hasil = hasil * i;
                   
                }
                else
                { 
                }
                
            }
            Console.WriteLine(m+" Ededi ile "+n+" ededi arasindaki cut ededlerin hasili = "+hasil);
            Console.ReadLine();
        }
    }
}
