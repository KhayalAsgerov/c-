using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapitalBankAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balans = 1200;
            Console.WriteLine("Kapital Banka Xosgelmisiniz");
            Console.WriteLine("Kartinizi Daxil Edin");
            Console.WriteLine("Davam etmek ucun dil secin");
            Console.WriteLine("Azerbaycan dili ucun 1 duymesini secin    Rus dili ucun 2 duymesini secin   Ingilis dili ucun 3 duymesini secin");
            string dil = Console.ReadLine();
            if (dil == "1")
            {
                Console.WriteLine("Siz Azerbaycan dilini sectiniz");
                Console.ReadLine();
            }
            else if (dil == "2")
            {
                Console.WriteLine("Siz Rus dilini Sectiniz");
                Console.ReadLine();
            }
            else if (dil == "3")
            {
                Console.WriteLine("Siz Ingilis dilini Sectiniz");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girdiyiniz duyme yalnisdir");
                Console.ReadLine();
            }
            Console.WriteLine("Etmek istediyiniz Emeliyyati Secin");
            Console.WriteLine("Balansinizi yoxlamaq ucun 1 duymesini secin");
            Console.WriteLine("Balansinizdan pul cekmek ucun 2 duymesini secin");
            Console.WriteLine("Balansinizi Artirmaqucun 3 duymesini secin");
            Console.WriteLine("Cixmaq ucun 4 duymesini secin");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Sizin Balansiniz " + balans + "manat teskil edir");
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek istediyiniz pul miqdarini yazin");
                int pulmiq = Convert.ToInt32(Console.ReadLine());
                if (pulmiq > 1200)
                {
                    Console.WriteLine("Cekmek istediyiniz pul miqadri balansinizda yoxdur");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Balansiniz = " + (balans - pulmiq));
                    Console.ReadLine();
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Kocurmek istediyiniz meblegi girin");
                int kocmeb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Balansiniz = " + (balans + kocmeb));
                Console.ReadLine();

            }

            else if (secim == "4")
            {
                Console.WriteLine("Hesabinizdan cixis verildi");
                Console.WriteLine("Kartinizi goturun");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girdiyiniz duyme yalnisdir");
                Console.ReadLine();
            }

        }
    }
}
