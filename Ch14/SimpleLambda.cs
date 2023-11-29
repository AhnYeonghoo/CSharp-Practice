using System;

namespace SimpleLambda
{
    class MainApp
    {
        delegate int Calculate(int a, int b);
        delegate string Concatenate(string[] args);

        static void MainSimpleLambda(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;
                return result;

            };
            Console.WriteLine(concat(args));
        }
    }
}