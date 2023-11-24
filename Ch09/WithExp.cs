using System;

namespace WithExp
{
    record RTRansaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void MainWithExp(string[] args)
        {
            RTRansaction tr1 = new RTRansaction { From = "Alice", To = "Bob", Amount = 100 };
            RTRansaction tr2 = tr1 with { To = "Chrile" };
            RTRansaction tr3 = tr2 with { From = "Dave", Amount = 30 };
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }
}