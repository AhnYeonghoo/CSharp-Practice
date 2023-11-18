using System;
using static System.Console;
using System.Collections;

namespace IncDecOperator
{
    class MainApp
    {
        static void MainIncDecOperator(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);

            string result = "123" + "456";
            Console.WriteLine(result);
            result = "Hello" + " " + "World";
            Console.WriteLine(result);

            Console.WriteLine($"3 > 4 : {3 > 4}");
            Console.WriteLine($"3 >= 4 : {3 >= 4}");

            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True: {!true}");
            Console.WriteLine($"!false: {!false}");

            string result2 = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result2);

            ArrayList a2= null;
            a2?.Add("야구");
            a2?.Add("축구");
            WriteLine($"Count : {a2?.Count}");
            WriteLine($"{a2?[0]}");
            WriteLine($"{a2?[1]}");

            a2 = new ArrayList();
            a2?.Add("축구");
            a2?.Add("야구");
            WriteLine($"Count: {a2?.Count}");
            WriteLine($"{a2?[0]}");
            WriteLine($"{a2?[1]}");

            WriteLine("Testing << ...");

            int a3 = 1;
            WriteLine("a3      : {0:D5} (0x{0:X8})", a3);

            int k = 9;
            int j = 10;

            WriteLine($"{k} & {j} : {k & j}");
            WriteLine($"{k} | {j} : {k | j}");
            WriteLine($"{k} ^ {j} : {k ^ j}");

            a = 100;
            WriteLine($"a = 100 : {a}");
            a += 90;
            WriteLine($"a += 90 : {a}");
            a -= 80;
            WriteLine($"a -= 80 : {a}");
            a *= 70;
            WriteLine($"a *= 70 : {a}");
            a /= 60;
            WriteLine($"a /= 60 : {a}");
            a %= 50;
            WriteLine($"a %= 50 : {a}");

            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }
    }
}