using System;

namespace BoxingUnboxing
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            double x = 3.1414121;
            object y = x;
            double z = (double)y;
            
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}