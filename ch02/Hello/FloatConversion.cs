using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatConversion
{
    internal class FloatConversion
    {
        public static void MainFloatConversion(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine(a);

            double b = (double)a;
            Console.WriteLine(b);

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            double y = (double)x;
            Console.WriteLine("hello World");
        }
    }
}
