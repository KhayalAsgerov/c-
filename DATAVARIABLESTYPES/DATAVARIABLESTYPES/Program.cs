using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAVARIABLESTYPES
{
    internal class Program
    {
        private const string V = "maxdeger";

        static void Main(string[] args)
        {
            // A. REQEMSAL DEYISKENLER NUMERATIC VARIABLES
            // 1 TAM SAYILAR (INTEGERS)
            byte maxdeger = byte.MaxValue; // 1byte     0 255
            byte mindeger = byte.MinValue;
            Console.WriteLine(mindeger);
            Console.WriteLine(maxdeger);
            sbyte sbytmindeger = sbyte.MinValue; // 1byte     -128 +128
            sbyte sbytmaxdeger = sbyte.MaxValue;
            Console.WriteLine(sbytmindeger);
            Console.WriteLine(sbytmaxdeger);
            short shrtmindeger = short.MinValue; // 2byte      -32768 +32768
            short shrtmaxdeger = short.MaxValue;
            Console.WriteLine(shrtmindeger);
            Console.WriteLine(shrtmaxdeger);
            ushort ushrtmindeger = ushort.MinValue; // 2byte    0 65535
            ushort ushrtmaxdeger = ushort.MaxValue;
            Console.WriteLine(ushrtmindeger);
            Console.WriteLine(ushrtmaxdeger);
            int intemindeger = int.MinValue; // 4byte   -2 milyon + 2 milyon
            int intemaxdeger = int.MaxValue;
            Console.WriteLine(intemindeger);
            Console.WriteLine(intemaxdeger);
            uint untmindeger = uint.MinValue; // 4byte    0   4 milyon
            uint untmaxdeger = uint.MaxValue;
            Console.WriteLine(untmindeger);
            Console.WriteLine(untmaxdeger);
            long lngmindeger = long.MinValue; // 8byte    -9 trlyrd +9 trlyrd
            long lngmaxdeger = long.MaxValue;
            Console.WriteLine(lngmindeger);
            Console.WriteLine(lngmaxdeger);
            ulong ulgmindeger = ulong.MinValue;// 8byte    0   18trlyrd 
            ulong ulgmaxdeger = ulong.MaxValue;
            Console.WriteLine(ulgmindeger);
            Console.WriteLine(ulgmaxdeger);
            // 2 ONDALIK VE KOKLU SAYILAR (DECIMALS)
            float fltmindeger = float.MinValue; // 4byte  7pille
            float fltmaxdeger = float.MaxValue;
            Console.WriteLine(fltmindeger);
            Console.WriteLine(fltmaxdeger);
            double dblmindeger = double.MinValue; // 8byte 16 pille
            double dblmaxdeger = double.MaxValue;
            Console.WriteLine(dblmindeger);
            Console.WriteLine(dblmaxdeger);
            decimal dcmlmindeger = decimal.MinValue; // 16byte 29 pille
            decimal dcmlmaxdeger = decimal.MaxValue;
            Console.WriteLine(dcmlmindeger);
            Console.WriteLine(dcmlmaxdeger);
            // B. METIN DEGISENLER CHARACTHER STRING VARIABLES
            char birherf = 'M'; // 2byte  birxarakterli 
            Console.WriteLine(birherf);
            string metn = "SALAM XOSGELDINIZ"; // charsayi*2byte 2milyon xarakterli 
            Console.WriteLine(metn);
            // C. MENTIQ DEGISENLERI LOGICAL VARIABLES
            bool yoxla = 7 > 9; // 2byte  true or false
            Console.WriteLine(yoxla);
            bool yoxla1 = 5 < 10;
            Console.WriteLine(yoxla1);
            // 1byte = 8bit
            // 1kb = 1024byte
            // 1mb = 1024kb
            // 1gb = 1024mb
            // 1tb = 1024gb
            // 1pb = 1024tb (petabyte)






            Console.ReadLine();


        }
    }
}
