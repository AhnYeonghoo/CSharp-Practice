using System;

namespace Return
{
    class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n < 2) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }
            Console.WriteLine($"name:{name}, Phone: {phone}");
        }

        static void MainReturn(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
        }
    }
}