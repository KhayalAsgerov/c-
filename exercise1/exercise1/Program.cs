using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk Notunuzu Girin : ");
            string ilknot = Console.ReadLine();
            int ilknot1 = Convert.ToInt32(ilknot);
            Console.WriteLine("Ikinci Notunuzu girin : ");
            string ikincinot = Console.ReadLine();
            int ikincinot2 = Convert.ToInt32(ikincinot);
            int sum = (ilknot1 + ikincinot2) / 2;

            if (sum > 45)
            {
                Console.WriteLine("Gectiniz");
                Console.ReadLine();
            } 
            else
            { 
            Console.WriteLine("Gecemediniz");
                Console.ReadLine();
            }
        }
    }
}
