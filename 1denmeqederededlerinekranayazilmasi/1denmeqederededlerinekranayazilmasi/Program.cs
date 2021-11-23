using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1denmeqederededlerinekranayazilmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-den girdiyiniz ededlere qeder olan ededlerin ekrana yazilmasi ucun bir eded girin");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-den " + M + " qeder olan ededler");
            for (int i = 1; i<M; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
