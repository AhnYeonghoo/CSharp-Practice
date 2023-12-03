using System;
using System.IO;

namespace SeqNRand
{
    class MainApp
    {
        static void MainSeqNRand(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x01);
            Console.WriteLine($"Position : {outStream.Position}");

        }
    }
}