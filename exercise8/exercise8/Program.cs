using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen ededin reqemleri cemi ve hasilini tapan proqram
            /*
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mult = 1;
            int basmk = eded * 1;
            int counter = 1;
            for (int j = 0; basmk/10>0; j++)
            { 
            counter++;
                basmk =basmk / 10;
            }
           
            for (int j=0;j<counter;j++)
            {
                int reqem = eded % 10;
                if (eded > 9)
                {
                    sum = sum + reqem;
                    mult = mult * reqem;
                    eded = (eded - eded % 10) / 10;


                }
                else
                {
                    sum = sum + eded;
                    mult = mult * eded;
                    Console.WriteLine("girdiyin ededin reqemleri cemi = "+sum);
                    Console.WriteLine("Girdiyin ededin reqemleri hasili = " + mult);
                }
            }
           Console.ReadLine(); */


            // 8000 qeder olan reqemlerinin kublari cemi ozune beraber olan en kicik ededi tapan proqram
            /*

             for (int i = 1; i < 8000; i++)
             {
                 int reqem = i%10;
                 if (i < 10)
                 { 
                 if(i*i*i==i)
                         Console.WriteLine(i);
                 }
                 else if (i > 9 && i < 100)
                 {
                     int birli = (i - reqem) / 10;
                     if((birli*birli*birli)+(reqem*reqem*reqem)==i)
                         Console.WriteLine(i);
                 }
                 else if (i > 99 && i < 1000)
                 {
                     int ikili1 = (i - reqem) / 10;
                     int ikili2 = ikili1 % 10;
                     int birli = (ikili1 - ikili2) / 10;
                     if ((birli * birli * birli) + (ikili2 * ikili2 * ikili2) + (reqem * reqem * reqem) == i)
                     { Console.WriteLine(i); }
                 }
                 else if (i > 1000) 
                 {
                 int uclu1=(i- reqem) / 10; 
                     int uclu2=uclu1 % 10;
                     int ikili1=(uclu1-uclu2)/10;
                     int ikili2=ikili1 % 10;
                     if ((uclu2 * uclu2 * uclu2) + (ikili2 * ikili2 * ikili2) + (reqem * reqem * reqem) == i)
                     { Console.WriteLine(i); }
                 }

             }

            Console.ReadLine(); */

            // girilen ededin nece basamakli oldugun tapan proqram
            /*
            Console.WriteLine("Bir eded daxil edin");
            int eded =Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            for(int i = 0; i<eded/10;i++)
            {
                counter++;
                eded = eded/10;
                

            }
            Console.WriteLine("girdiyiniz eded " +counter+" basamaklidir");
            Console.ReadLine(); */


            // verilen ededin ikinin quveti olub olmadigin tapan proqram
            /*
            Console.WriteLine("Bir eded daxil edin");
           double eded = Convert.ToInt32(Console.ReadLine());
            double bolme = 1;
            for (double i =0;1<eded;i++ )
            {
                bolme = eded / 2;
                eded = eded / 2;
            }
            if (bolme == 1)
            {
                Console.WriteLine("Girdiyiniz eded 2 nin quvvetidir");
            }
            else
            {
                Console.WriteLine("Girdiyiniz eded 2 nin quvveti deil");
            }
            Console.ReadLine(); */



            // girilen ededin polindrom olub olmadigini tapan alqoritim

            /*
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());
            string son2 = Convert.ToString(eded);
            int reqem=eded%10;
            int counter = 1;
            int eded1 = eded * 1;
            string cem = "";
            string reqem1 = Convert.ToString(reqem);

            for (int j = 0; 0 < eded / 10; j++)
            {
                counter++;
                eded = eded / 10;
            }
           
            for (int i = 0; i < counter; i++)
            {
            
                 reqem = eded1%10;
                
                if (eded1 > 9)
                {
                    reqem1 = Convert.ToString(reqem);
                    cem += reqem1;
                    eded1 = (eded1 - reqem) / 10;
                }
                else 
                {
                string son = Convert.ToString(eded1);
                    cem += son;
                    
                }
            }
            if (cem == son2)
            { Console.WriteLine("Girdiyiniz eded polindromdur"); }
            else
            {
                Console.WriteLine("Girdiyiniz eded polindrom deil");
            }
            Console.ReadLine(); */


            // girilen ededin qarsisina 3 elave edib yazdiran proqram
            /*
            Console.WriteLine("Bir eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int son = eded;
            int sum = 0;
            int x = 3;

            for (int i = 0; eded > 0;i++)
            {
                int reqem = eded % 10;
                x = x * 10;
                eded = (eded - reqem) / 10;
            }
            sum=x+son;
            Console.WriteLine(sum);
           Console.ReadLine(); */


            // girilen ededin qarsisina 3 elave edib yazdiran proqram
            /*
            Console.WriteLine("bir eded gir");
            string eded =Console.ReadLine();
            Console.WriteLine("3"+eded);
            Console.ReadLine(); */


            // girilen ededin qarsisina 3 elave edib yazdiran proqram
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int x = 1;
            for(int i = 0; x<=eded;i++)
            {
                x *= 10;
            }
            sum = eded + 3*x;
            Console.WriteLine(sum);
            Console.ReadLine();





        }

    }
}
