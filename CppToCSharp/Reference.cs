using System;
using System.Drawing;

namespace Reference
{
    class Reference
    {
       static void ChangeVal(ref int a)
        {
            Console.WriteLine(a);
            a = 3;
            return;
        }

        static void Main()
        {
            int a = 10;
            ChangeVal(ref a);
            Console.WriteLine(a);

        }

    }
}