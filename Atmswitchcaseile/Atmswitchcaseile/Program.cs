using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atmswitchcaseile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 500;
            Console.WriteLine("Atm-e Hosgeldiniz");
            Console.WriteLine("Yapmak istediginiz islemi seciniz");
            Console.WriteLine("1. Bakiyenizi gotuntulemek icin 1 dugmesini seciniz");
            Console.WriteLine("2. Para cekmek icin 2 duymesini seciniz");
            Console.WriteLine("3. Para yatirmak icin 4 dugmesini seciniz");
            Console.WriteLine("Cikis yapmak icin 4 dugmesini seciniz");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1" :
                    Console.WriteLine("Bakiye miktariniz = " + bakiye);
                    break;

                    case "2" :
                    Console.WriteLine("Cekmek istediginiz miktari giriniz");
                    int cekm = Convert.ToInt32(Console.ReadLine());
                    if (cekm > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para cekemezsiniz");
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz = " + (bakiye-cekm));

                    }
                    break;

                    case "3" :
                    Console.WriteLine("Yatirmak istediginiz parayi giriniz");
                    int yp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bakiyeniz = " + (bakiye + yp));
                    break;

                case "4":
                    Console.WriteLine("Cikis yapiliyor Iyi gunler");
                    break;

                    default :
                    Console.WriteLine("Lutfen gecerli bir sayi giriniz");
                    break ;




            }
            Console.ReadLine();
        }
    }
}
