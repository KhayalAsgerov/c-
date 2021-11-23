using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenucreqemliededinreqemlericemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ucreqemli eded girin");
            int gired = Convert.ToInt32(Console.ReadLine());
            if (gired >= 100 && gired < 1000)
            {
                int qaliq = gired % 100;
               int bir1 = gired - qaliq;
                int bir = bir1 / 100;
                int uc = qaliq % 10;
                int iki2 = qaliq - uc;
                int iki = iki2 / 10;
                Console.WriteLine("Girdiyiniz ededin reqemleri cemi = " + (bir + iki + uc));
            }
            else {
                Console.WriteLine("Daxil etdiyiniz eded ucreqemli deil");
            }
            Console.ReadLine();


        }
    }
}
