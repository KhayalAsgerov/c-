using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int uzunluk;
              string kelime;
              Console.WriteLine("Bir kelime giriniz");
              kelime=Console.ReadLine();
              uzunluk = kelime.Length;
              for (int i = uzunluk; i > 0; i--)
              { 
              Console.Write(kelime.Substring(i-1,1));
              }
              Console.ReadLine(); */
           
            Console.WriteLine("bir sayi giriniz");
            int say = Convert.ToInt32( Console.ReadLine());
            

            for (int i = 1; i < say; i++)
            {
                for (int x = 1; x < say; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("#");
            }
            
          
            
           Console.ReadLine();



        }
    }
}
