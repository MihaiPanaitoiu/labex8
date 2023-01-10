using System;

namespace labex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Supliment 1
• Se citesc doua numere de la tastatura. Scrieti un program care va calcula
cel mai mare divizor comun al numerelor
             */
            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("M=");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(GetCmmmdc(n, m));
        }

        static int GetCmmmdc(int n, int m)
        {
            if (n < m)
            {
               return GetCmmmdc(m - n, n);
            } else if(m < n)
            {
                return GetCmmmdc(n - m, m);
            } else
            {
                return n;
            }
        }

    }
}
