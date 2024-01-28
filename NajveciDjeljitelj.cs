using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prvi broj: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("unesi drugi broj: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);
            Console.WriteLine("Najveci djeljitelj oba broja je {0}", gcd);

            Console.ReadKey();
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
