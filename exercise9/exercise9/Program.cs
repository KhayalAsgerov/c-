using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8000 e qeder olan ededler icerisinde ededin reqemlerinin kublari cemi edede beraber olaan ededlerin yazilmasi alqoritmi
            /*
            int sum = 0;
            int kub = 1;
            int temporary = 1;
            for (int i = 10; i < 8000; i++)
            {
                sum *= 0;
                 temporary = 1*i;
                for (int j = 0; temporary  > 0; j++)
                {
                    int reqem = temporary % 10;
                    kub = reqem * reqem * reqem;
                    sum += kub;
                    temporary = (temporary - reqem) / 10;
                }
                if (sum == i)
                { Console.WriteLine(sum); }
            }
            Console.ReadLine(); */

            //Girdiyiniz eded qeder olan reqemlerinin kvadratlari cemi 100 beraber olan ededleri yazdiran proqram
            /*
            Console.WriteLine("Bir eded girin ");
            int eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int kvad = 1;
            for (int i = 10; i < eded; i++)
            {
                sum = sum*0;
               
                int temporary = 1;
                temporary = temporary * i;
                for (int j = 0; temporary > 0; j++)
                {
                    int reqem = temporary % 10;
                    kvad = reqem * reqem;
                    sum+=kvad;
                    temporary = (temporary - reqem) / 10;
                }
                
               
                if (sum == 100)
                { Console.WriteLine(i); }
            }
            Console.ReadLine(); */


            // girilen ededin reqemleri cemi ve hasilin tapan proqram

            /*
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mult = 1;
            for (int i = 0; eded > 0; i++)
            {
                int reqem = eded % 10;
                mult *= reqem;
                sum += reqem;
                eded = (eded-reqem)/10;
            }
            Console.WriteLine("Girilen ededin reqemleri cemi = "+sum);
            Console.WriteLine("Girilen ededin reqemleri hasili = "+mult);
            Console.ReadLine(); */

            // girilen ededin qarsisina 3 elave edib yeni eded duzelden proqran
            /*
            Console.WriteLine("Bir eded girin");
            int eded=Convert.ToInt32(Console.ReadLine());
            int result = 3;
            int eded1 = eded * 1;
            for (int i = 0; eded > 0; i++)
            {
                int reqem = eded % 10;
                result *= 10;
                eded = (eded - reqem) / 10;
                    
                    }
           
            Console.WriteLine("yeni eded =" + (result+eded1));
            Console.ReadLine(); */


            // girilen ededin 2nin quvveti olub olmadigin tapan proqram
            /*
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; eded > 1; i++)
            {
                eded /= 2;
            }
            if (eded == 1)
            { Console.WriteLine("Girilen eded ikinin quvvetidir"); }
            else
            { Console.WriteLine("Girilen eded ikinin quvveti deil"); }
            Console.ReadLine(); */


            // Girilen ededin qarsisina 3 elave ederek yeni eded duzelden proqram
            /*
            Console.WriteLine("Bir eded girin");
            int eded =Convert.ToInt32(Console.ReadLine());
            int result = 1;
            int art = 3;

            for (int i = 0; eded >= result; i++)
            {
                result *= 10;
            }

            result = (result * art) + eded;

            Console.WriteLine("Yeni eded = "+result);
            Console.ReadLine(); */

            // Girilen ededin polidrom olub olmadigin tapan proqram
            /*
            
            Console.WriteLine("Bir eded girin");
            int eded =Convert.ToInt32(Console.ReadLine());
            int eded1 = eded * 1;
            int sum = 0;
            int onlq = 1;
            for (int i = 0; eded >= onlq; i++)
            {
                onlq = onlq * 10;
            }
            for (int j = 0; eded > 0; j++)
            {
                int reqem = eded % 10;
                onlq= onlq /10;
                int sum1 = reqem * onlq;
                sum += sum1;
                eded = (eded - reqem) / 10;
            }

            if (eded1 == sum)
            { Console.WriteLine("Girilen eded polidromdur"); }
            else
            { Console.WriteLine("Girilen eded polidrom deil"); }
        Console.ReadLine(); */
        }
    }
}
