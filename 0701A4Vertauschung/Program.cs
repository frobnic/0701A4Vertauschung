using System;

namespace _0701A4Vertauschung
{
    class Program
    {
        static void schwapp(ref int a, ref int b)
        {
            int t;

            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
        }

        static void Main(string[] args)
        {
            int x = 7, y = 2;

            Console.WriteLine("{0} {1}", x, y);

            schwapp(ref x, ref y);

            Console.WriteLine("{0} {1}", x, y);
        }
    }
}
