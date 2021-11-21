using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolereadline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.readLine(); 1 .konsolu ekrenda tutar 2 .konsola kullanicinin girdiyi verileri degisenlere aktarir.
         
            Console.WriteLine("Adinizi yazin  - ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadinizi yazin - ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Kullanicinin Adi :" + ad);
            Console.WriteLine("Kullanicinin Soyadi :" + soyad);
            Console.ReadLine();
        }
    }
}
