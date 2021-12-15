using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded girin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int maxnumber = eded % 10;
            int n = (eded - maxnumber) / 10;
            if (eded > 9 && eded < 100)
            {
                {
                    if (maxnumber > n)
                    { Console.WriteLine("ededin en boyuk reqemi = " + maxnumber); }
                    else

                    { Console.WriteLine("ededin en boyuk reqemi =" + (eded - maxnumber) / 10); }
                }
            }
            else if (eded > 99 && eded < 1000)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (maxnumber > n % 10)
                    {

                    }
                    else
                    {
                        maxnumber = n % 10;
                    }
                    if (maxnumber > (n - n % 10) / 10)
                    {
                        Console.WriteLine(maxnumber);
                    }
                    else
                    {
                        maxnumber = (n - n % 10) / 10;
                        Console.WriteLine(maxnumber);
                    }

                }


            }

            Console.ReadLine();

        }
           
        }
    }
}
