using System;

namespace OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine(name + phone);
        }

    }
}