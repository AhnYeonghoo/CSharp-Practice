using System;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }
            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void MainExtensionMethod(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
        }
    }
}