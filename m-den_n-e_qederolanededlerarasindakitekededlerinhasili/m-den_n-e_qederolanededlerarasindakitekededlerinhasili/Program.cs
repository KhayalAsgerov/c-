using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_den_n_e_qederolanededlerarasindakitekededlerinhasili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hasil=1;
            Console.WriteLine("m ededini daxil edin");
           int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n ededini daxil edin");
           int n = Convert.ToInt32(Console.ReadLine());

            for (int i = m; m < n; m++)
            {
                if (m % 2 == 1)
                {
                    hasil = hasil * m;
                }
                else
                {

                }
            }
            Console.WriteLine(hasil);
            Console.ReadLine();
            
    
        }
    }
}
