using System;
using static System.Console;
using System.Globalization;

namespace StringFormatDatetime
{
    class StringFormatDatetime
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));

            string name = "김튼튼";
            int age = 23;
            WriteLine($"{name, -10}, {age:D3}");

            name = "박날씬";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");

            name = "이비실";
            age = 16;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");

        }
    }
}