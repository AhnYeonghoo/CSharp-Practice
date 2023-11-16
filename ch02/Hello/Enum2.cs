using System;

namespace Enum2
{
    class Enum2
    {
        enum DialogResult { YES, NO, CANCEl, CONFIRM, OK}
        
        static void MainEnum2(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
        }
    }
}