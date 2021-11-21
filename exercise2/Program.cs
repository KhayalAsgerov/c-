using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci notunuzu giriniz : ");
            int birincinot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci notonuzu giriniz : ");
            int ikincinot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-cu notonuzu giriniz : ");
            int ucuncunot = Convert.ToInt32(Console.ReadLine());
            int ort = (birincinot + ikincinot + ucuncunot) / 3;

            if (ort > 80 && ort < 100)
            {
                Console.WriteLine("PUANINIZ A+");
                
            }
            else if (ort > 60 && ort < 80)
            {
                Console.WriteLine("PUANINIZ A");
              
            }
            else if (ort > 40 && ort < 60)
            {
                Console.WriteLine("PUANINIZ B+");
              
            }
            else
            {
                Console.WriteLine("PUANINIZ F");
           
            }
            Console.ReadLine();
        }
    }
}
