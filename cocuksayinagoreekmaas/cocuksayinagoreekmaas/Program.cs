using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocuksayinagoreekmaas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cocuk Sayisina Gore Alcaginiz EK Maasi Hesaplamaniz icin Coucuk Sayisini Giriniz ");
            int cocuksay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maasinizi Giriniz");
            int maas = Convert.ToInt32(Console.ReadLine());
            switch (cocuksay)
            { 
            case 0:
                    Console.WriteLine("Ek maas = " + 0);
                    Console.WriteLine("Maas = " + maas);
                    break;
                 case 1:
                    Console.WriteLine("Ek maas = " + (maas * 0.05));
                    Console.WriteLine("Tam MAAs = " + (maas * 0.05 + maas));
                    break;
                case 2:
                    Console.WriteLine("Ek maas = " + (maas * 0.10));
                    Console.WriteLine("Tam MAAs = " + (maas * 0.10 + maas));
                    break;
                default:
                    Console.WriteLine("Ek maas = " +(maas * 0.15));
                    Console.WriteLine("Tam MAAS = " + (maas * 0.15 + maas));
                    break;


            }

            Console.ReadLine();
        }
    }
}
