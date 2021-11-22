using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bk = 1000;
            Console.WriteLine("1. Bakiye gormek   2. Para Cekmek     3. Para Yatirma    4. CIKIS");
            Console.WriteLine("Yapmak istediginiz islem numarasini giriniz");
            string M = Console.ReadLine();
            if (M == "1")
            {
                Console.WriteLine(bk);
                Console.ReadLine();
            }
            else if (M == "2")
            {
                Console.WriteLine("Cekmek istediginiz Bakiye Miktarini Giriniz");
                string ckbk = Console.ReadLine();
                int ckbk1 = Convert.ToInt32(ckbk);
                if (ckbk1 > 1000)
                {
                    Console.WriteLine("Cekmek Istediginiz Bakiye Miktari Bakiyenizden Fazla Lutfen yeniden giriniz");
                    int ckbk2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine( "BEKLEYINIZ");
                    Console.WriteLine("Paranizi Aliniz");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Paranizi Alin");
                    Console.ReadLine();
                }

            }
            else if (M == "3")
            {
                Console.WriteLine("Yatirmak istediginiz para miktarini giriniz");
                int ytmk = Convert.ToInt32(Console.ReadLine());
                int tbk = bk + ytmk;
                Console.WriteLine("Toplam Bakiyeniz - " + tbk);
                Console.ReadLine();

            }
            else if (M == "4")
            {
                Console.WriteLine("Cikmak Icin Q_ye Basiniz");
                Console.WriteLine("Hesabinizdan Cikis Yapiliyor");
                Console.WriteLine("Cikis Yapildi Iyi Gunler");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girdiginiz Islem Numarasi Yalnisdir");
                Console.ReadLine();
            }

        }
    }
}
