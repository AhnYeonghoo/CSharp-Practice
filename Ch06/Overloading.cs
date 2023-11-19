using System;

namespace Overloading
{
    class MainApp
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            return a + b;
        }

        static double Plus(int a, double b)
        {
            return a + b;
        }


    }
}