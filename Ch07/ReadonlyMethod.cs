using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }
}