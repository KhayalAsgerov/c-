using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Örnek 1: Klavyeden öğrencinin 2 adet not bilgisi girildikten sonra, ortalama 50 ve üzerinde ise ekrana “Geçti” değilse “Kaldı”
            // yazdıran programın Console uygulamasını yapalım.
            /* Console.WriteLine("Not bilgilerinizi giriniz");
             Console.WriteLine("ilk notunuzu giriniz");
             int not1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("ikinci notunuzu giriniz");
             int not2 = Convert.ToInt32(Console.ReadLine());
             int ort = (not1 + not2) / 2;
             if (ort >= 50)
             {
                 Console.WriteLine("Tebrikler Gectiniz ortalamaniz = " + ort);

             }
             else
             {
                 Console.WriteLine("Uzgunzuz Gecemediniz ortalamaniz = " + ort);
             }
             Console.ReadLine(); */


            // Örnek 2: Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı sayılmaktadırlar.
            // Öğrencinin vize notu ortalamaya %40, final notu %60 etki ettiği bildiğine göre öğrencilerin ders başarı durumlarını hesaplayan programı yapalım.
            /*
            Console.WriteLine("Not bilgilerinizi giriniz");
            Console.WriteLine("vize notunuzu giriniz");
            int vizenot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunuzu giriniz");
            int finalnot = Convert.ToInt32(Console.ReadLine());
            double ort = (vizenot * 0.4) + (finalnot * 0.6);
            if (ort>=50)
            {
                Console.WriteLine("Tebrikler Gectiniz ortalamaniz = " + ort);

            }
            else
            {
                Console.WriteLine("Uzgunzuz Gecemediniz ortalamaniz = " + ort);
            }
            Console.ReadLine(); */



            // Örnek 3: Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı”
            // mesajı veren Console uygulamasını yapalım.
            /*
            Console.WriteLine("Kullanici adinizi giriniz");
            string kulad = Console.ReadLine();
            Console.WriteLine("Sifrenizi giriniz");
            string sifre = Console.ReadLine();
            if (kulad == "rauf" && sifre == "1234")
            {
                Console.WriteLine("Giris Basarili");
            }
            else 
            {
                Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
            }
            Console.ReadLine(); */



            // Örnek 4: Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren C# programını yazalım
            /*
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiginiz sayi cift sayidir");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi tek sayidir"); 
            
           }

            Console.ReadLine(); */



            // Örnek 5: Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır.
            // Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren programı yazalım
            /*
            Console.WriteLine("Urun fiyatini giriniz");
            double urunfiyat =Convert.ToDouble(Console.ReadLine());
           
            if (urunfiyat >= 100)
            {
                Console.WriteLine("Odeyeceginiz toplam tutar = " + (urunfiyat+5));
            }
            else
            {
                Console.WriteLine("Odeyeceginiz toplam tutar = " + urunfiyat);
            }
            Console.ReadLine(); */


            // Örnek 6: Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren programın C# kodlarını yazalım.
            /*
            Console.WriteLine("bir sayi giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("Sayi Pozitivdir");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayi Negativdir");
            }
            else
            {
                Console.WriteLine("Sayi Sifra esittir");
            }

            Console.ReadLine(); */



            // Örnek 7: Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde,
            // sonucu hesaplayarak ekranda gösteren programı yazalım.
            /*
            Console.WriteLine("Birinci sayiyi Giriniz");
            double birsayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi Giriniz");
            double iknsayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapilacak islem turunu seciniz");
            Console.WriteLine("toplama icin 1 seciniz __ Cikarma icin 2 seciniz __ Carpma icin 3 seciniz __ Bolme icin 4 seciniz");
            double islem = Convert.ToDouble(Console.ReadLine());


            if (islem == 1)
            {
                Console.WriteLine("Girdiginiz sayilarin Toplami = " + (birsayi + iknsayi));
            }
            else if (islem == 2)
            {
                Console.WriteLine("Girdiginiz sayilarin Cikarmasi = " + (birsayi - iknsayi));
            }
            else if (islem == 3)
            {
                Console.WriteLine("Girdiginiz sayilarin Carpimi = " + (birsayi * iknsayi));
            }
            else if (islem == 4)
            {
                Console.WriteLine("Girdiginiz sayilarin Bolumu = " + (birsayi / iknsayi));
            }
            else
            {
                Console.WriteLine("Girdiginiz islem kodu yalnistir. Boyle bir islem yapilamaz");
            }
            Console.ReadLine(); */




            // Örnek 8: Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise,
            // 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
            /*
            Console.WriteLine("Birinci urunun fiyatini giriniz");
            double birfiyt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci urunun fiyatini giriniz ");
            double ikifiyt = Convert.ToDouble(Console.ReadLine());
            double topfiyt = birfiyt + ikifiyt;
            if (topfiyt > 200)
            {
                Console.WriteLine("Odenecek tutar = " + ((ikifiyt * 0.25) + birfiyt));
            }
            else
            {
                Console.WriteLine("Odenecek tutar = " + topfiyt);
            }

            Console.ReadLine(); */


            // C# Switch Case Örnekleri 
            // Klavyeden girilen sayının hangi güne ait olduğunu bulan program.
            /*
            Console.WriteLine("Bir sayi Giriniz");
            string sayi = Console.ReadLine();
            switch (sayi)
            { 
            case "1" : Console.WriteLine("Pazartesi");
                    break;
                case "2": Console.WriteLine("Sali");
                    break ;
                case "3": Console.WriteLine("Carsamba");
                    break;
                    case"4": Console.WriteLine("Persembe");
                    break;
                    case"5": Console.WriteLine("Cuma");
                    break;
                    case "6": Console.WriteLine("Cumaertesi");
                    break;
                case "7": Console.WriteLine("Pazar");
                    break;
                    default: Console.WriteLine("Girdiginiz sayi yalnisdir");
                    break;

            }
                Console.ReadLine(); */



            // Klavyeden girilen sayının hangi aya ait olduğunu bulan C# programını Switch-case kullanarak yazın
            /*
           Console.WriteLine("Lütfen bir sayı giriniz");
           int sayi = Int32.Parse(Console.ReadLine());

           switch (sayi)
           {

               case 1: Console.WriteLine("Ocak"); break;
               case 2: Console.WriteLine("Şubat"); break;
               case 3: Console.WriteLine("Mart"); break;
               case 4: Console.WriteLine("Nisan"); break;
               case 5: Console.WriteLine("Mayıs"); break;
               case 6: Console.WriteLine("Haziran"); break;
               case 7: Console.WriteLine("Temmuz"); break;
               case 8: Console.WriteLine("Ağustos"); break;
               case 9: Console.WriteLine("Eylül"); break;
               case 10: Console.WriteLine("Ekim"); break;
               case 11: Console.WriteLine("Kasım"); break;
               case 12: Console.WriteLine("Aralık"); break;

               default: Console.WriteLine("Hata Böyle bir ay yok"); break;
           }

           Console.ReadLine(); */



            // Kullanıcının girdiği iki sayı ve yapılacak işlem türleri (toplama=1, çıkarma=2, çarpma=3, bölme=4)
            // gösterilen ve  seçilen işlemi yapan C# programını  switch-case ile yazın
            /*
            Console.WriteLine("Birinci sayiyi giriniz");
            double sayi1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi giriniz");
            double sayi2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediginiz islemi secinz");
            Console.WriteLine("toplama icin 1 seciniz __ Cikarma icin 2 seciniz __ Carpma icin 3 seciniz __ Bolme icin 4 seciniz");
            int islem = Convert.ToInt32( Console.ReadLine());
            switch (islem)
            {
                case 1: Console.WriteLine("Girdiginiz sayilarin Toplami = " + (sayi1+sayi2)); break;
                    case 2: Console.WriteLine("Girdiginiz sayilarin Cikarmasi = " + (sayi1 - sayi2)); break;
                case 3: Console.WriteLine("Girdiginiz sayilarin Carpimi = " + (sayi1*sayi2)); break;
                case 4: Console.WriteLine("Girdiginiz sayilarin Bolumu = " + (sayi1/sayi2)); break;
                default: Console.WriteLine("Boyle bir islem bulnmamakta. Lutfen dogru islemi seciniz"); break;
            
            
            }

            Console.ReadLine(); */



            // Klavyeden girilen günün hafta içi veya haftasonu olduğunu bulan C# programını switch-case ile yazın
            /*
            Console.WriteLine("Birgun giriniz");
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "1": Console.WriteLine("Haftaici"); break;
                case "2": Console.WriteLine("Haftaici"); break;
                case "3": Console.WriteLine("Haftaici"); break;
                case "4": Console.WriteLine("Haftaici"); break;
                case "5": Console.WriteLine("Haftaici"); break;
                case "6": Console.WriteLine("Haftasonu"); break;
                case "7": Console.WriteLine("Haftasonu"); break;
                    default: Console.WriteLine("Lutfen dogru sayi giriniz"); break;
            }
            Console.ReadLine(); */


            // Trafik lamba renklerine göre hangi işlemlerin yapılacağını söyleyen
            // C# programını Switch-case ile  yazın. ( Kırmızı : Dur   Sarı : Hazır ol   Yeşil: İlerle)
            /*
            Console.WriteLine("Trafik lamba rengini girniz");
            string lambreng = Console.ReadLine();
            switch (lambreng)
            {

                case "kirmizi": Console.WriteLine("Dur"); break;
                case "sari": Console.WriteLine("Hazir ol"); break;
                case "yesil": Console.WriteLine("Ilerle"); break;
                default: Console.WriteLine("Lutfen dogru rengi yaziniz"); break;
            }
            Console.ReadLine(); */


            // C# For Döngüsü Örnekleri

            // Ekrana 5 defa “Merhaba Dünya” yazan C# programını yazın.
            /*
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("merhaba dunya");
            }
            Console.ReadLine(); */



            // 0’dan 1000’e kadar ekrana yazan C# programını yazın.
            /*
            for (int i = 0; i < 101; i++)
            { Console.WriteLine(i); }
            Console.ReadLine(); */


            // A’dan Z’ye kadar ekrana yazan C# programının kodları.
            /*
            for (char i = 'A'; i <= 'Z'; i++)
            { Console.WriteLine(i); }
            Console.ReadLine(); */



            // 5’den 0’a kadar ekrana yazan C# programında geriye doğru yani azaltarak işlem yapan C# kodu ekrana 54321 yazacaktır
            /*
            for (int i = 5; i >= 0; i--)

            { Console.WriteLine(i); }
            Console.ReadLine(); */


            // Klavyeden girilen sayı kadar ekrana Merhaba Dünya yazan C# programının kodları.
            /*
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            { Console.WriteLine(i + " Merhaba Dunya"); }
            Console.ReadLine(); */



            // 1-100 arası 3′ e ve 5’e tam bölünebilen sayıları listeleyen Console Örneği
            /*
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine(); */



            // 1-100 arası 3’e tam bölünemeyen sayıları listeleyen Console Örneği:
            /*
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0)
                { Console.WriteLine(i); }
            }
            Console.ReadLine(); */



            // 1 den kullanıcının girdiği sayıya kadar olan sayıları listeleyen Console Örneği:
            /*
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); */


            // Kullanıcını girdiği 2 sayı arasındaki sayıları listeleyen Console Örneği:
            /*
            Console.WriteLine("Baslangic sayisin giriniz");
            int bassayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitis sayisini giriniz");
            int bitsayi = Convert.ToInt32(Console.ReadLine());
            bassayi++;
            for (int i = bassayi; i < bitsayi; i++)
            { Console.WriteLine(i); }
            Console.ReadLine(); */



            // Kullanıcının girdiği 2 sayı arasındaki 4 ile tam bölünebilen sayıları ekrana yazdıran Console Örneği:
            /*
            Console.WriteLine("Baslangic sayisin giriniz");
            int bassayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitis sayisini giriniz");
            int bitsayi = Convert.ToInt32(Console.ReadLine());
            bassayi++;
            for (int i = bassayi; i < bitsayi; i++)
            {
                if (i % 4 == 0)
                { Console.WriteLine(i); }
            }
            Console.ReadLine(); */



            // C# 10’luk sayı sisteminden 2’lik sayı sistemine çeviren program
            /*
            Console.WriteLine("2li say sistemine gecmek istediginiz sayiyi giriniz");
            Console.WriteLine("ondalikli bir sayi giriniz");
            string sayi = Convert.ToString(Console.ReadLine());
            double eded = sayi.Length;
            eded--;
            double sayi1 = Convert.ToDouble(sayi);
            if (eded == 2)
            { Console.WriteLine(sayi1 * 10); }
            else if (eded == 3)
            { Console.WriteLine(sayi1*100); }
            else if (eded == 4)
            { Console.WriteLine(sayi1 * 1000); }
            else if (eded == 5)
            { Console.WriteLine(sayi1 * 10000); }
            else if (eded == 6)
            { Console.WriteLine(sayi1 * 100000); }
            else if (eded == 7)
            { Console.WriteLine(sayi1 * 1000000); }
            Console.ReadLine(); */

            //
            /*
            for (int i = 1; i < 10; i++)
            {
               
                for (int j = 1; j <= i; j++)
                { Console.Write(j); }
            }

            Console.ReadLine(); */


            //
            /*
            int i =0;
            while (i <= 10)
            {
                 Console.WriteLine(i); i++;
            }
            Console.ReadLine(); */


            int i =100;
            while (i > 0)
            {
                i = i - 2; Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
