using System;

namespace FloatingPoint
{
    class FloatingPoint
    {
        static void Main6(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);

            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;
            Console.WriteLine(c);
        }
    }
}