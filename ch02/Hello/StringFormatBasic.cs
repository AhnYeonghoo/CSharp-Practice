using System;
using static System.Console;

namespace StringFormatBasic
{
    class StringFormatBasic
    {
        static void MainStringFormatBasic(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}