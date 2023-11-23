using System;

namespace InitOnly
{
    class Transaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            
                return $"{From,-10} -> {To,-10} : ${Amount}";
            
        }
    }
}