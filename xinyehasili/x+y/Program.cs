using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X - ededini daxil edin");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y - ededini daxil edin");
            int y = Convert.ToInt32(Console.ReadLine());
            int mult = x* y;
            Console.WriteLine("Ededlerin hasili = " + mult);
            Console.ReadLine();

        }
    }
}
