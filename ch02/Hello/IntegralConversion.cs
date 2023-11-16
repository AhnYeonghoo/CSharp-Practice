using System;

namespace IntegralConversion
{
    class IntegralConversion
    {
        static void MainIngegralConversion(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.Write(b);

            int x = 128;
            Console.WriteLine(x);
            sbyte y = (sbyte)x;
            Console.WriteLine(y);
        }
    }
}