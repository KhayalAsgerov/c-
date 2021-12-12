using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] numbers = new int[] {2, 4, 6, 8, 10 };
            int sum = 0;
            int edort = 0;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    sum += numbers[i];
                    counter++;
                    
                    edort = sum/counter;
                }
                
            }
            Console.WriteLine(edort);
            Console.ReadLine(); */
            /*
            int[] numbers = {4, 12,675,345,22,18,171};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 9 && numbers[i] < 100)
                { 
                sum+=numbers[i];
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine(); */
            /*
            double price, endirim, totalamount;
            Console.WriteLine("Alinan urunlerin toplam fiyatini giriniz ");
            price= Convert.ToDouble(Console.ReadLine());
            if (price < 100)
            {
                endirim = price * 0.10;
                totalamount = price - endirim;
                Console.WriteLine("Sizin toplam tutariniz = " + totalamount);
            }
            else if (price >= 100 && price < 150)
            {

                endirim = price * 0.15;
                totalamount = (price - endirim);
                Console.WriteLine("Sizin toplam tutariniz = " + totalamount);
            }

            else
            {
                endirim = price * 0.20;
                totalamount= (price - endirim);
                Console.WriteLine("Sizin toplam tutariniz = " + totalamount);
            }
            Console.ReadLine(); */
            /*
            Console.WriteLine("Bir sayi giriniz");
            string sayi = Console.ReadLine();
            switch (sayi)
            {
                case "1": Console.WriteLine("Pazartesi"); break;
                case "2": Console.WriteLine("Sali"); break;
                    case"3": Console.WriteLine("Carsamba"); break;
                    case"4": Console.WriteLine("Persembe"); break;
                    case"5": Console.WriteLine("Cuma"); break;
                    case"6": Console.WriteLine("Cumartesi"); break;
                case "7": Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Boyle gun mevcut degil"); break;

            }
            Console.ReadLine(); */
            /*
            string sezon;
            Console.WriteLine("Sezon adini girin");
            sezon = Console.ReadLine();

            switch (sezon)
            {
                case "yay": Console.WriteLine("Yay aylari: iyun iyul avqust"); break;
                case "yaz": Console.WriteLine("Yaz aylari : mart aprel may"); break;
                case "qis": Console.WriteLine("Qis aylari : dekabr yanvar fevral"); break;
                case "payiz": Console.WriteLine("Payiz aylari : sentyabr oktyabr noyabr"); break;
                    default: Console.WriteLine("Bele sezon yoxdur"); break;

                    
                    
            
            }
             Console.ReadLine(); */

            /*
            Console.WriteLine("120 Qeder olan 120 tam bolunen ededler");
            for(int i = 1; i <= 120; i++)
            {
                if (120 % i == 0)
                { Console.WriteLine(i); }

            }
            Console.ReadLine(); */
            /*

            int a , b , c;
            a = 1;
            b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 18; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine(); */

            /*
            int i = 0;
            int counter = 0;    
            while (i < 10)
            {
                i++;
                counter++;
                Console.WriteLine(counter+". Hello World");
            }
            Console.ReadLine(); */
            /*
            int i = 0;
            while (i<10)
            { i++; 
                Console.WriteLine(i); }
            Console.ReadLine(); */
            /*
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            while (sayi%2==0)
            { Console.WriteLine("Bir sayi giriniz");
            sayi=Convert.ToInt32(Console.ReadLine());
            }
            { Console.WriteLine("tek sayi girdiniz"); };
            Console.ReadLine();  */
            /*
            Console.WriteLine("Faktoryalini istediginiz sayini giriniz");
            long faktoryal = Convert.ToInt32(Console.ReadLine());
            long i = 0;
            long mult = 1;
            while (i<faktoryal)
            { 
            i++;
                mult *= i;
                
            }
            Console.WriteLine("Girdiyiniz ededin faktoryali = " + mult);
            Console.ReadLine(); */
            /*
            string[] sehirler = { "Istanbul", "Ankara", "Adana", "Bursa" };
            Console.WriteLine(sehirler[0]+ " " +sehirler[1]+" "+sehirler[2] + " "+ sehirler[3]);
            Console.ReadLine(); */
            /*
            string[] sehirler = { "baki", "seki", "sumqayit", "gence" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.Write(sehirler[i]+"  ");
            }
            Console.ReadLine(); */
            /*
            int[] ededler = new int[4] ;
            int sum = 0;
            for(int i = 0; i<ededler.Length;i++)
            {
                Console.WriteLine("Bir eded girin");
                ededler[i] = Convert.ToInt32(Console.ReadLine()) ;
             sum+=ededler[i] ;
               
            }
            Console.WriteLine("Girdiyiniz ededlerin cemi = " + sum);
            Console.ReadLine(); */
            /*
            int[] sayilar = new int[5]; 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir sayi giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            if (sayilar[0] > sayilar[1] && sayilar[0] > sayilar[2] && sayilar[0] > sayilar[3] && sayilar[0] > sayilar[4])
            { Console.WriteLine("girdiginiz en buyuk sayi = "+sayilar[0]); }
            else if (sayilar[1] > sayilar[0] && sayilar[1] > sayilar[2] && sayilar[1] > sayilar[3] && sayilar[1] > sayilar[4])
            { Console.WriteLine("girdiginiz en buyuk sayi = " + sayilar[1]); }
            else if (sayilar[2] > sayilar[0] && sayilar[2] > sayilar[1] && sayilar[2] > sayilar[3] && sayilar[1] > sayilar[4])
            { Console.WriteLine("girdiginiz en buyuk sayi = " + sayilar[2]); }
            else if (sayilar[3] > sayilar[0] && sayilar[3] > sayilar[2] && sayilar[3] > sayilar[1] && sayilar[3] > sayilar[4])
            { Console.WriteLine("girdiginiz en buyuk sayi = " + sayilar[3]); }
            else if (sayilar[4] > sayilar[0] && sayilar[4] > sayilar[2] && sayilar[4] > sayilar[3] && sayilar[4] > sayilar[1])
            { Console.WriteLine("girdiginiz en buyuk sayi = " + sayilar[4]); }
            Console.ReadLine(); */
            /*
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            { Console.WriteLine("Bir sayi giriniz"); 
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enboyuk = sayilar[0];
            for(int i=1;i<5;i++)
            {
                if (sayilar[i] > enboyuk) 
                enboyuk = sayilar[i];
               
            }
            Console.WriteLine("Girdiyiniz en buyuk sayi = "+ enboyuk);
            Console.ReadLine(); */
            /*
            string[] adlar = new string[5];
            string[] soyadlar = new string[5];
            double[] imtahan1 = new double[5];
            double[] imtahan2 = new double[5];
            double[] imtahan3 = new double[5];
            double[] ortalama = new double[5];
            for(int i = 0; i<5;i++)
            {
                Console.WriteLine((i+1)+". "+"Telebenin adini girin");
                adlar[i] =Console.ReadLine();
                Console.WriteLine((i + 1) + ". " + "Telebenin soyadini girin");
                soyadlar[i] =Console.ReadLine();
                Console.WriteLine( "Telebenin 1 ci imtahan qiymetini girin");
                imtahan1[i]=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Telebenin 2 ci imtahan qiymetini girin");
                imtahan2[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Telebenin 3 cu imtahan qiymetini girin");
                imtahan3[i] = Convert.ToDouble(Console.ReadLine());
                ortalama[i] = (imtahan1[i] + imtahan2[i] + imtahan3[i]) / 3;
                Console.Clear();

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Telebenin adi: "+adlar[i]);
                Console.WriteLine("Telebenin soyadi: "+ soyadlar[i]);
                Console.WriteLine("Telebenin qiymet ortalamasi: "+ortalama[i] ); 
                
            }
            Console.ReadLine(); */
        }
        
    }
}
