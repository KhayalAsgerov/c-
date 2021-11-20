using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operators are used to perform operations values and variables
            // 1. Arithmetic Operators (Riyazi Operatorlar) are used to perform common mathematical operations.
            // a. + Addition x+y
            int x = 6;
            int y = 5;
            int sum = x+ y;
            Console.WriteLine("sum : "+sum);
            // b. - Subtraction x-y
            int sayi1 = 22;
            int sayi2 = 11;
            Console.WriteLine("subtraction :"+(sayi1 - sayi2)) ;
            // c. Multiplication x*y
            int mult = sayi1 * sayi2;
            Console.WriteLine("multiplication :" + mult);
            // d. Division x/y
           int div = sayi1 / sayi2;
            Console.WriteLine("division :"+div);
            // e. Modulus x%y
            int mod = x % y;
            Console.WriteLine("modulus :" + mod);
            // Increment ++ x++==x+1
            x++;
            Console.WriteLine(x);
            // Decrement x--==x-1
            y--;
            Console.WriteLine(y);
            // 2. Assigment Operators (Teyinat(Menimsetme) Operatorlari) are used to assign values to variables.
            // a. = Aktarma x=5
            int aktar = 5;
            Console.WriteLine(aktar);
            // b. += x+=y x=x+y
            int m = 6;
            m += 5;
            Console.WriteLine(m);
            // c. -= x-=y x=x-y
            m -= 3;
            Console.WriteLine(m);
            // c. *= x*=y x=x*y
            m *= 2;
            Console.WriteLine(m);
            // d. /= x/=y x=x/y
            m /= 4;
            Console.WriteLine(m);
            // 3. Comparison Operators (Muqayise operatorlari) are used to compare two values.
            // a. == equal to
            int n = 7;
            bool check = n == 7;
            Console.WriteLine(check);
            // b. != not equal to
            bool check1 = n != 7;
            Console.WriteLine(check1);
            // c. > greater than
            int z = 10;
            bool check2 = z > n;
            Console.WriteLine(check2);
            // d. < less than
            bool check3 = z < n;
            Console.WriteLine(check3);
            // e. >= greather than or equal to
            bool check5 = z >= n;
            Console.WriteLine(check5);
            // f. <= less than or equal to
            bool check6 = z <= n;
            Console.WriteLine(check6);
            // 4. Logical Operators (Mentiqi Operatorlar) are used to determine the logical between variables or values.
            // a. && logical and returns true if both statements are true
            int eded1 = 12;
           int eded2 = 15;
            int eded3 = 8;
            bool yoxla = eded1 > eded3 && eded2 > eded1;
            Console.WriteLine(yoxla);
            // b. || logical or returns true if one of the statement is true
            bool yoxla2 = eded2 > eded1 || eded3 > eded2;
            Console.WriteLine(yoxla2);
            // c. ! logical not reverse the result if the result is true
            
            Console.ReadLine();
        }
    }
}
