using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 den 100 qeder ededlerin ekrana yazilmasi");
            int i =  1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
