using System;

namespace FuncTest
{
    class MainApp
    {
        static void MainFuncTest()
        {
            Func<int> func1 = () => 10;
            Console.WriteLine(func1());

            Func<int, int> func2 = (x) => (x * 2);
            Console.WriteLine(func2(2));

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine(func3(22, 7));
        }
    }
}