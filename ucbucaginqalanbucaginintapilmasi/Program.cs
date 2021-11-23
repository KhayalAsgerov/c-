using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucbucaginqalanbucaginintapilmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ucbucagin birnci bucagin girin");
            int bir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucbucagin ikinci bucagin girin");
            int iki = Convert.ToInt32(Console.ReadLine());
            int uc = 180 - (bir + iki);
            if ((bir + iki) >= 180)
            {
                Console.WriteLine("Girdiyiniz Bucaqlar Ucbucaga Aiddeil");
            }
            else
            {
                Console.WriteLine("Ucbucagin ucuncu bucagi = " + uc);
            }
            Console.ReadLine();
        }
    }
}
