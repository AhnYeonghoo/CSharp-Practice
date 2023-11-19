using System;

namespace SwapByValue
{
    class MainApp
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void MainSwapByValue(string[] args)
        {

        }
    }
}