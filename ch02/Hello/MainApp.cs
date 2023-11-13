using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        static void Main1(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("여러분, 안녕하세요?\n반갑습니다!");
        }
    }
}