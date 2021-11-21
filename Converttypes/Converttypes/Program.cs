using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converttypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // converting int variable data type to byte variable data type.
            // byte a = (byte) a;
            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(a);
            // converting string variable data type to int variable data type.
            // convert.TolINT32();
            // int.Parse();
            string x = "8";
            string y = "12";
            int z= Convert.ToInt32(x);
            int f = Convert.ToInt32(y);
            Console.WriteLine(z+f);
            Console.WriteLine(x + y);
            // converting integer variable data type to string variable data type.
            // x.ToString();
            int c = 34;
            int d = 22;
            string g = c.ToString();
            string h = d.ToString();
            Console.WriteLine(g+h);
            Console.WriteLine(c+d);
            // converting double variabe data type to integer variable data type.
            // Convert.toINT32();
            double n = 32.234;
            int m = Convert.ToInt32(n);
            Console.WriteLine(m);
            Console.WriteLine(n);
            // converting string variable data type to duoble variable data type .
            // convert.ToDouble();
            string s = "4.235";
            double s2 = Convert.ToDouble(s);
            Console.WriteLine(s2);
            Console.WriteLine(s2.GetType());
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
