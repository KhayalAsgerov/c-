using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedenkutleindexi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden kutle indexinizi oyrenmek ucun cekinizi(kg) girin ");
            int kutle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Boyunuzu girin");
            double boy = Convert.ToDouble(Console.ReadLine());
            double index = kutle / (boy * boy);
            if (index <= 18)
            {
                Console.WriteLine("ZEIF");
            }
            else if (index > 18 && index <= 25)
            {
                Console.WriteLine("NORMAL");
            }
            else 
            {
                Console.WriteLine("OBEZ");
            }

            Console.ReadLine();

        }
    }
}
