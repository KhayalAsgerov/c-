using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1’den 10’a kadar olan sayıları alt alta ekrana yazdıralım

            /*for (int i = 1; i <= 10; i++)
            { 
            Console.WriteLine(i);
            }
            Console.ReadLine();*/


            // 1 ile 40 arasındaki çift sayıları toplayarak sonucu ekranda gösterelim. (40 dahil olsun).
            // 1
            /*
            int sum = 0;
            for (int i = 0; i <= 40; i += 2)
            {
                sum=sum+i;
                
            }
            Console.WriteLine("cem = " + sum);
            Console.ReadLine(); */

            //2

            /*
            int sum =0;
            for (int i = 1; i <= 40; i++)
            {
                if ( i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("CEM = " + sum);
            Console.ReadLine(); */

            //  Klavyeden girilen sayının faktöriyelini bulan programı yapalım.

            /*
                         Console.WriteLine("Lutfen bir sayi giriniz");
                         int sayi =Convert.ToInt32( Console.ReadLine());
                         int faktoryel = 1;
                         for (int i = sayi; i >1 ; i--)
                         {
                             faktoryel = faktoryel * i;

                         }
                         Console.WriteLine("faktoryel = " + faktoryel);

                         Console.ReadLine(); */


            // 1’den 9’lara kadar olan klasik çarpım tablosunu oluşturalım.

            /*
             int mult;
             for (int i = 1; i <= 9; i++)
             {
                 for (int j = 1; j<=9; j++)
                 {
                     mult = i * j;
                     string k = Convert.ToString(i);
                     string l = Convert.ToString(j);
                     Console.WriteLine(k + "*" + l + " = " + mult);
                 }
                 Console.Write("##################"); Console.WriteLine("");

             }

             Console.ReadLine(); */

            // Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdır
            /*
            int mult = 1;
            for (int i=1; i<=10; i++ )
            {
                
                Console.WriteLine("bir sayi giriniz : "  );
                 int sayi = Convert.ToInt32( Console.ReadLine());
                if (sayi > 0 && sayi % 2 == 1)
                {
                    mult = mult * sayi;
                    
                
            }
            }
            Console.WriteLine("girdiginiz sayilar icersinde tek ve pozitif sayilarin carpimi = " + mult);


            Console.ReadLine();
            */

            // girilen metni alt alta yazdir

            /*
            string cumle = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                Console.WriteLine(cumle[i]);
            }
            Console.ReadKey();
            */

            /*
            char z = 'Z';
            for ( char a = 'A'; a<=z; a++ )

            {
            Console.WriteLine(a);
            }
            Console.ReadLine();

              */

            // Kullanıcıdan aldığı 10 adet sayıyı toplayarak ekranda gösteren uygulama.
            /*
             int sum = 0;

             for (int i = 1; i <= 10; i++)
             { 
             Console.WriteLine("Bir sayi Giriniz : " );
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 sum = sum + sayi;

             }
             Console.WriteLine("Girdiginiz sayilarin toplami = " + sum );
             Console.ReadLine(); */

            // Kullanıcıdan 10 adet isim alarak başına numaraların da ekleyerek ekranda yazdıran örnek.


            /*
            Console.WriteLine(" 10 adet Isim Giriniz");
            for (int i = 1; i <=10;  i++)
            {
                Console.Write(i + ". ");
                string isim = Console.ReadLine();

            }
            Console.ReadLine(); */

            // Klavyeden girilen bir sayıya kadar tek sayıların ve çift sayıların toplamını bulan program.

            /*
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int cifttoplam = 0;
            int tektoplam = 0;
            for(int i = 0; i<sayi; i++)
            {
                if (i % 2 == 0)
                {
                    cifttoplam += i;
                }
                else 
                {
                    tektoplam +=i;
                }
            }
            Console.WriteLine("cift sayilarin toplami = " + cifttoplam);
            Console.WriteLine("tek sayilarin toplami = " + tektoplam);
            Console.ReadLine(); */


            // Kullanıcının girdiği metni kullanıcının girdiği sayıda ekranda yazdıran Console örneği
           
            Console.WriteLine("kac defa yazilacak");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            string metn = Console.ReadLine();
            for (int i = 1; i < sayi; i++)
            {
                Console.WriteLine(metn);
            }
            Console.ReadLine();
        }
    }
}
