using System;

namespace InitializingArray
{
    class MainApp
    {
        static void MainInitializingArray(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            string[] array3 = { "안녕", "Hello", "Halo" };
        }
    }
}