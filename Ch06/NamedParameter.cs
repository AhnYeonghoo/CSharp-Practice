using System;

namespace NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"name:{name}, phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-1234-1234");
        }
    }
}