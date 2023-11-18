using System;

namespace While
{
    class MainApp
    {
        static void MainWhile(string[] args)
        {
            int i = 10;
            
            while ( i> 0)
            {
                Console.WriteLine($"i : {i--}");
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
        }

    }
}